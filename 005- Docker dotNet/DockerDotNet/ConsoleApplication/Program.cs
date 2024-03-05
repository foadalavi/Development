using Docker.DotNet;
using Docker.DotNet.Models;

namespace ConsoleApplication
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var cancellation = new CancellationTokenSource();
            await RunContainer(cancellation.Token);
            cancellation.Dispose();
        }

        static async Task RunContainer(CancellationToken cancellationToken)
        {
            bool isStarted = false;
            DockerClient client = null;
            string containetrId = null;
            try
            {
                client = new DockerClientConfiguration().CreateClient();
                var tty = true;
                var containerInstance = await client.Containers.CreateContainerAsync(new CreateContainerParameters()
                {
                    Image = "console-application:1.0.0",
                    Cmd = new[] { "2", "3" },
                });
                containetrId = containerInstance.ID;
                ContainerLogsParameters logParameters = new ContainerLogsParameters()
                {
                    ShowStdout = true,
                    ShowStderr = true,
                    Follow = true,
                };

                isStarted = await client.Containers.StartContainerAsync(containetrId, new ContainerStartParameters(), cancellationToken);

                using (MultiplexedStream logStream = await client.Containers.GetContainerLogsAsync(containetrId, tty, logParameters, cancellationToken))
                {
                    (string stdout, string stderr) = await logStream.ReadOutputToEndAsync(cancellationToken);
                    Console.WriteLine("The output of the docker application is: {0}.", stdout);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (client != null && isStarted)
                {
                    var stopped = await client.Containers.StopContainerAsync(containetrId,
                                        new ContainerStopParameters
                                        {
                                            WaitBeforeKillSeconds = 30
                                        }, cancellationToken);
                    await client.Containers.RemoveContainerAsync(containetrId, new ContainerRemoveParameters(), cancellationToken);
                }
            }
        }
    }
}

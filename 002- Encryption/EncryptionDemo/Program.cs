namespace EncryptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// SymmetricAlgorithm 
            //var text = "Do not forget to like and subscribe!";
            //var password = "This is my super secure password!{you can use a GUID}";
            //var encryptedTextInByte = SymmetricEncryption.Encrypt(password, text);
            //Console.WriteLine($"Encrypted message:\n{Convert.ToBase64String(encryptedTextInByte)}");
            //Console.WriteLine($"\nOriginal text length: {text.Length}");
            //Console.WriteLine($"\nEncrypted text length: {encryptedTextInByte.Length}");


            //var decryptedText = SymmetricEncryption.Decrypt(password, encryptedTextInByte);
            //Console.WriteLine($"The original text:  {text}");
            //Console.WriteLine($"the decrypted text: {decryptedText}");
            //Console.ReadKey();


            // AsymmetricAlgorithm 
            var text = "Do not forget to like and subscribe!";
            var (publicKey, privateKey) = AsymmetricEncryption.GenerateKey();
            Console.WriteLine($"\nPublic Key:\n{publicKey}\n\nPrivate Key:\n{privateKey}");
            Console.ReadKey();
            Console.Clear();
            var encryptedTextInByte = AsymmetricEncryption.Encrypt(publicKey, text);
            var SignedData = AsymmetricEncryption.Sign(privateKey, text);
            Console.WriteLine($"Encrypted message:\n{Convert.ToBase64String(encryptedTextInByte)}");
            Console.WriteLine($"\nSigned message:\n{Convert.ToBase64String(SignedData)}");
            Console.WriteLine($"\nOriginal text length: {text.Length}");
            Console.WriteLine($"Encrypted text length: {encryptedTextInByte.Length}");


            Console.WriteLine($"The original text:  {text}");
            Console.WriteLine($"The decrypted text: {AsymmetricEncryption.Decrypt(privateKey, encryptedTextInByte)}");
            Console.WriteLine($"Verify the Message: {AsymmetricEncryption.Verify(publicKey, text, SignedData)}");
            Console.WriteLine($"Verify the manipulated Message: {AsymmetricEncryption.Verify(publicKey, text + "1", SignedData)}");
            Console.ReadKey();
        }
    }
}

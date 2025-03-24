namespace miw_genetic_alg
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            var decodeTable = Parameters.CreateDecodeTable(-1.0, 1.0, 3);
            string table = "";
            for (uint i = 0; i <= (uint)Math.Pow(2, 3) - 1; i++)
            {
                byte[] key = [ (byte)((i & 4) >> 2), (byte)((i & 2) >> 1), (byte)(i & 1) ];
                var value = decodeTable[key];
                table += "" + key[0] + key[1] + key[2] + " => " + value + '\n';
            }
            MessageBox.Show(table);
        }
    }
}
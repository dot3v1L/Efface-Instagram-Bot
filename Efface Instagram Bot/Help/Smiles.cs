using System;

namespace Efface_Instagram_Bot.Help
{
    class Smiles
    {
        static Random rnd = new Random();
        static string[] LoveSmile = { "💋", "💌", "💘", "💝", "💖", "💗", "💓", "💞", "💕", "💟", "❣", "💔", "❤", "💙", "💚", "💚", "💙", "💐", "💜",
            "🤎", "🖤", "👄", "👅" };

        static string[] FlowerSmile = { "💐", "🌸", "💮", "🏵", "🌹", "🥀", "🌺", "🌻", "🌼", "🌷" };
        static string[] FruitsSmile = {  "🍅", "🍆", "🍇", "🍈", "🍉", "🍊", "🍌", "🍍", "🍎", "🍏", "🍑", "🍒", "🍓" };
        static string[] CatSmile = {"😸", "😹", "😺", "😻", "😼", "😽", "😾", "😿", "🙀" };
        static string[] FaceSmile = { "🥰","😁", "😂", "😃", "😄", "😅", "😆", "😉", "😊", "😋", "😌", "😍", "😏", "😒", "😓", "😔", "😖", "😘", "😚",
            "😜", "😝", "😞", "😠", "😡", "😢", "😣", "😤", "😥", "😨", "😩", "😪", "😫", "😭", "😰", "😱", "😲", "😳", "😵", "😷", };

        public static string GetSmile(int num, bool? love = false, bool? flower = false, bool? fruit = false,
            bool? cat = false, bool? face = false)
        {
            string smiles = "";
            for (int i = 0; i < num; i++)
            {
                if (love ?? true)
                    smiles += LoveSmile[rnd.Next(0, LoveSmile.Length)];
                if (flower ?? true)
                    smiles += FlowerSmile[rnd.Next(0, FlowerSmile.Length)];
                if (fruit ?? true)
                    smiles += FruitsSmile[rnd.Next(0, FruitsSmile.Length)];
                if (cat ?? true)
                    smiles += CatSmile[rnd.Next(0, CatSmile.Length)];
                if (face ?? true)
                    smiles += FaceSmile[rnd.Next(0, FaceSmile.Length)];
            }

            return smiles;
        }

    }
}

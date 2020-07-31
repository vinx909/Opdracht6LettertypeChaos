using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht6LettertypeChaos
{
    public partial class Form1 : Form
    {

        private const int lengthSameFont = 1;

        private List<Font> fontFamilies;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            SetupFontFamilies();
            SetupRandon();
        }

        private void SetupFontFamilies()
        {
            if (fontFamilies == null)
            {
                fontFamilies = new List<Font>();
                FontFamily[] families = FontFamily.Families;
                foreach(FontFamily family in families)
                {
                    fontFamilies.Add(new Font(family, RichTextBoxToShuffle.Font.Size));
                }
            }
        }

        private void SetupRandon()
        {
            if (random == null) {
                random = new Random();
            }
        }

        private void ButtonShuffleFont_Click(object sender, EventArgs e)
        {
            RichTextBoxShuffleResult.Text = RichTextBoxToShuffle.Text;
            int length = RichTextBoxShuffleResult.Text.Length;
            for(int i = 0; i < length; i++)
            {
                RichTextBoxShuffleResult.Select(i, lengthSameFont);
                RichTextBoxShuffleResult.SelectionFont = fontFamilies[random.Next(fontFamilies.Count)];
            }
        }
    }
}

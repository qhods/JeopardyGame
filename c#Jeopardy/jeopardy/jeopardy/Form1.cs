using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeopardy
{
    public partial class Jeopardy : Form
    {
        public int total = 0;
        public Jeopardy()
        {
            InitializeComponent();
        }
        /***********************Row One*********************************/
        private void button1Row1_Click(object sender, EventArgs e)
        {
            string message = "Known for supernatural gothic fantasy films that use " +
                "exaggeration and color for storytelling that mix light/dark and life/death";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if(result == DialogResult.OK)
            {
                string answer = "Who is Tim Burton?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 200;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 200;
                }
                else
                {
                    total += 0;
                }
            }
            
            Control ctrl = ((Control)sender);
            switch(ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch(ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button2Row1_Click(object sender, EventArgs e)
        {
            string message = "Made by Otto Messmer, this film was known for a cat who climbed question marks " +
                "while figuring out a way to help the Nifty Nine win their game";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Felix Saves the Day?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 200;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 200;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button3Row1_Click(object sender, EventArgs e)
        {
            string message = "Sculpted objects or characters that are placed, photographed, " +
                                "and then slightly moved again";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Clay Animation?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 200;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 200;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button4Row1_Click(object sender, EventArgs e)
        {
            string message = "This element was not used in early animation, but was eventually added " +
                "and is now an important cinematic element";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is music?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 200;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 200;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button5Row1_Click(object sender, EventArgs e)
        {
            string message = "Created by Max Fleischer during the silent era, this character acted life like by interacting with" +
                " the animator/audience";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Koko the Clown?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 200;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 200;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button6Row1_Click(object sender, EventArgs e)
        {
            string message = "Hand painted pictures on glass that are then projected using " +
                "a mirror and light";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is magic lantern?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 200;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 200;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        /*************************************************************/
        /************Row Two***************************************/
        private void button1Row2_Click(object sender, EventArgs e)
        {
            string message = "Known for many great films like 'How a Mosquito Operates', 'Sinking of the Lusitania', and " +
                "films including interaction between him and the character ";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Winsor McCay?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 400;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 400;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button2Row2_Click(object sender, EventArgs e)
        {
            string message = "Made by Wladyslaw Starewicz, this stop motion film included " +
                    "two of his favorite things which were animation and bugs";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is The Camera Man's Revenge?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 400;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 400;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button3Row2_Click(object sender, EventArgs e)
        {
            string message = "This style uses puppets and materials that are layed flat to make the film";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is cut out animation?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 400;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 400;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button4Row2_Click(object sender, EventArgs e)
        {
            string message = "In early animation this element was only black and white";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is color?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 400;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 400;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button5Row2_Click(object sender, EventArgs e)
        {
            string message = "After accidently marrying the wrong woman, this character became stuck in another world";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Victor Vandort?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 400;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 400;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button6Row2_Click(object sender, EventArgs e)
        {
            string message = "In 1941 these employees went on strike because they were not given " +
                "bonuses and higher pay that was promised, instead some employees were laid off, but " +
                "the people who were still employed expereince unequal pay between the animators and everyone else";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Disney Strike?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 400;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 400;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        /***********************************************************/
        /******************Row 3***********************************/
        private void button1Row3_Click(object sender, EventArgs e)
        {
            string message = "Inspired by Willis O'Brien, this animator's first films were fairy tales then shortly after started making films " +
                "with monster like creatures";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Ray Harryhausen?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 600;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 600;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button2Row3_Click(object sender, EventArgs e)
        {
            string message = "This film was made by Hayao Miyazaki, that involved a girl and her family " +
                "wandering into another world where there are gods, witches, and all kinds of spirits";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Spirited Away?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 600;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 600;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button3Row3_Click(object sender, EventArgs e)
        {
            string message = "This style is known for being very time consuming because all of the " +
                "objects in the film have to be moved after each shot";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Stop Motion animation?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 600;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 600;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button4Row3_Click(object sender, EventArgs e)
        {
            string message = "This element has a big impact on animation by looking at an image " +
                "from different parts of the screen";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is camera angles?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 600;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 600;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button5Row3_Click(object sender, EventArgs e)
        {
            string message = "This cartoon character came out of Warner Bros Studio and was created by " +
                "Tex Avery, this character is known for their ongoing feud with Elmer Fudd";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Bugs Bunny?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 600;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 600;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button6Row3_Click(object sender, EventArgs e)
        {
            string message = "This time in history was a hard time for animators along with the rest of the country, " +
                "some animations that came out during this era were the 'Silly Symphonies' and 'Betty Boop'";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is the Great Depression?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 600;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 600;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        /**************************************************************/
        /*************Row 4*********************************************/
        private void button1Row4_Click(object sender, EventArgs e)
        {
            string message = "German animator that was known for the film 'The Adventures of Prince Achmed'";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Lotte Reinger?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 800;
                }
                else if(answerResult == DialogResult.No)
                {
                    total -= 800;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button2Row4_Click(object sender, EventArgs e)
        {
            string message = "This film was a coming of age true story about a girl during the Iranian Revolution";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Persepolis?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 800;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 800;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button3Row4_Click(object sender, EventArgs e)
        {
            string message = "This style shows characters not bending their limbs but instead the limbs " +
                "are more curved";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Rubberhose animation?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 800;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 800;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button4Row4_Click(object sender, EventArgs e)
        {
            string message = "This element is how long or short something is held for";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is timing?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 800;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 800;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button5Row4_Click(object sender, EventArgs e)
        {
            string message = "This character was in the first full length animated film by Disney that was accompanied by dwarfs";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Snow White?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 800;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 800;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button6Row4_Click(object sender, EventArgs e)
        {
            string message = "This studio started in 1921 by two brothers named Max and Dave";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Fleischer Studios?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 800;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 800;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        /**********************************************************/
        /*************Row 5**************************************/
        private void button1Row5_Click(object sender, EventArgs e)
        {
            string message = "This animator started his career in Kansas City with Walt Disney and made films like 'The Skeleton " +
                "Dance' and 'Steamboat Willie'"; 
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Ub Iwerks?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 1000;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 1000;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button2Row5_Click(object sender, EventArgs e)
        {
            string message = "This is a Canadian animation made by Wade Hemsworth that was for the National Film Board to " +
                "show the work people did on the river";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Log Driver's Walts?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 1000;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 1000;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button3Row5_Click(object sender, EventArgs e)
        {
            string message = "This technique is done by projecting frame by frame pictures and then the animator tracing the projections";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is rotoscope?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 1000;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 1000;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button4Row5_Click(object sender, EventArgs e)
        {
            string message = "How much something fills the screen";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is framing?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 1000;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 1000;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button5Row5_Click(object sender, EventArgs e)
        {
            string message = "This character was made in 1941 by Windsor McCay where she did tricks that McCay ordered in front " +
                "of a live audience";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "Who is Gertie the Dinosaur?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 1000;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 1000;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }
        private void button6Row5_Click(object sender, EventArgs e)
        {
            string message = "This studio was created by two brothers named Auguste and Louis " +
                "who were known for the first cinematograph";
            string title = " ";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                string answer = "What is Lumiere Bros?";
                string answerTitle = " ";
                MessageBoxButtons answerButtons = MessageBoxButtons.YesNoCancel;
                DialogResult answerResult = MessageBox.Show(answer, answerTitle, answerButtons);
                if (answerResult == DialogResult.Yes)
                {
                    total += 1000;
                }
                else if (answerResult == DialogResult.No)
                {
                    total -= 1000;
                }
                else
                {
                    total += 0;
                }
            }

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Blue":
                    ctrl.BackColor = Color.Black;
                    break;
            }
            switch (ctrl.ForeColor.Name)
            {
                case "Gold":
                    ctrl.ForeColor = Color.Black;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(total.ToString());
            Text = "Check/nTotal";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Directions:\n-Click a price box for the question\n-" +
                "After reading the question click OK and the answer will show up\n" +
                "-If you got it right click Yes, if you got it wrong click No, and if you don't " +
                "know click Cancel\n-To check your score click Check Total");
        }
    }
}

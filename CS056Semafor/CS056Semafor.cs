using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS056Semafor
{
    public partial class CS056Semafor : Form
    {
        public CS056Semafor()
        {
            InitializeComponent();
        }
       

        class Semafor
        {
            public enum Stav
            {
                Vypnuto,
                Zapnuto
            }

            public enum RizeniStav
            {
                Stop,
                PripravitVolno,
                Volno,
                PripravitStop,
                OranzoveSvetloZapnuto,
                OranzoveSvetloVypnuto
            }

            Stav stav = Stav.Vypnuto;
            RizeniStav rizeni = RizeniStav.OranzoveSvetloVypnuto;
            DateTime casPrechodu;


            TimeSpan intervalStop = new TimeSpan(0, 0, 5);
            TimeSpan intervalVolno = new TimeSpan(0, 0, 10);
            TimeSpan intervalPripraviVolno = new TimeSpan(0, 0, 2);
            TimeSpan intervalPripraviStop = new TimeSpan(0, 0, 2);
            TimeSpan intervalBlikani = new TimeSpan(0, 0, 1);

            PictureBox svetloCervene;
            PictureBox svetloOranzove;
            PictureBox svetloZelene;

            public Semafor(PictureBox svetloCervene, PictureBox svetloOranzove, PictureBox svetloZelene)
            {
                this.svetloCervene = svetloCervene;
                this.svetloOranzove = svetloOranzove;
                this.svetloZelene = svetloZelene;

                casPrechodu = DateTime.Now;

            }

            private void ZmenitStav(RizeniStav novyStav)
            {
                this.rizeni = novyStav;
                casPrechodu = DateTime.Now;
                Vykreslit();
            }

            public void Zapnout()
            {
                stav = Stav.Zapnuto;
                ZmenitStav(RizeniStav.OranzoveSvetloZapnuto);
                //if (stavPoZapnuti == RizeniStav.Volno)
                //{
                //    ZmenitStav(RizeniStav.PripravitVolno);
                //}
                //else
                //{
                //    ZmenitStav(RizeniStav.PripravitStop);
                //}

            }
            public void Vypnout()
            {
                stav = Stav.Vypnuto;
                ZmenitStav(RizeniStav.Stop);
           
            }
            public void Aktualizovat()
            {
                TimeSpan casOdPrepnuti = DateTime.Now - casPrechodu;
                bool zmenitStav;

                if (false)
                {

                }
                else
                {
                    zmenitStav = (stav == Stav.Zapnuto) && (casOdPrepnuti > intervalBlikani);
                    if (zmenitStav && rizeni == RizeniStav.OranzoveSvetloVypnuto)
                    {
                        ZmenitStav(RizeniStav.OranzoveSvetloZapnuto);
                    }
                    else if (zmenitStav)
                    {
                        ZmenitStav(RizeniStav.OranzoveSvetloVypnuto);
                    }

                }
            }
         
            public void Vykreslit()
            {
                ZhasnoutSvetla();

                switch (rizeni)
                {
                    case RizeniStav.OranzoveSvetloVypnuto:
                        
                        break;

                    case RizeniStav.OranzoveSvetloZapnuto:
                        svetloOranzove.Image = Properties.Resources.svetloZluta;
                        break;
                }

            }
            private void ZhasnoutSvetla()
            {
                svetloCervene.Image = Properties.Resources.svetloVypnute;
                svetloOranzove.Image = Properties.Resources.svetloVypnute;
                svetloZelene.Image = Properties.Resources.svetloVypnute;

            }
        }
     


        private void semaforTimer_Tick(object sender, EventArgs e)
        {
            this.semafor.Aktualizovat();
        }
        Semafor semafor; 

        private void CS056Semafor_Load(object sender, EventArgs e)
        {
            this.semafor = new Semafor(pictureBox1, pictureBox2, pictureBox4);
        }

        private void zapnoutButton_Click(object sender, EventArgs e)
        {
            this.semafor.Zapnout();
        }

        private void vypnoutButton_Click(object sender, EventArgs e)
        {
            this.semafor.Vypnout();
        }
    }
}

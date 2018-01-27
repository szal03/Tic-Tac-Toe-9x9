using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X turn, false = Y turn
        bool przeciwko_komputerowi = false;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
            start_blok_plansza_e();
        }

        private void button_click1(Object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            sprZwyciezce();
            Odblokowanie();
            if (b.Text != "")
                b.Enabled = false;
        }
        private void start_blok_plansza_e()
        {
            Button a = b1;
            Button b = b2;
            Button c = b3;
            Button d = b4;
            Button e = b5;
            Button f = b6;
            Button g = b7;
            Button h = b8;
            Button i = b9;
            //plansza c
            Button j = c1;
            Button k = c2;
            Button l = c3;
            Button m = c4;
            Button n = c5;
            Button o = c6;
            Button p = c7;
            Button r = c8;
            Button s = c9;
            //plansza d
            Button t = d1;
            Button u = d2;
            Button w = d3;
            Button y = d4;
            Button z = d5;
            Button aa = d6;
            Button ab = d7;
            Button ac = d8;
            Button ad = d9;
            // pomijam plansze e
            //plansza f
            Button an = f1;
            Button ao = f2;
            Button ap = f3;
            Button ar = f4;
            Button ass = f5;
            Button at = f6;
            Button au = f7;
            Button aw = f8;
            Button ay = f9;
            //plansza g
            Button az = g1;
            Button ba = g2;
            Button bb = g3;
            Button bc = g4;
            Button bd = g5;
            Button be = g6;
            Button bf = g7;
            Button bg = g8;
            Button bh = g9;
            //plansza h
            Button bi = h1;
            Button bj = h2;
            Button bk = h3;
            Button bl = h4;
            Button bm = h5;
            Button bn = h6;
            Button bo = h7;
            Button bp = h8;
            Button br = h9;
            //plansza i
            Button bs = i1;
            Button bt = i2;
            Button bu = i3;
            Button bw = i4;
            Button by = i5;
            Button bz = i6;
            Button ca = i7;
            Button cb = i8;
            Button cc = i9;
            //plansza a 
            Button cd = a1;
            Button ce = a2;
            Button cf = a3;
            Button cg = a4;
            Button ch = a5;
            Button ci = a6;
            Button cj = a7;
            Button ck = a8;
            Button cl = a9;
            //
            //plansza a 
            cd.Enabled = false;
            ce.Enabled = false;
            cf.Enabled = false;
            cg.Enabled = false;
            ch.Enabled = false;
            ci.Enabled = false;
            cj.Enabled = false;
            ck.Enabled = false;
            cl.Enabled = false;

            //plansza b
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
            e.Enabled = false;
            f.Enabled = false;
            g.Enabled = false;
            h.Enabled = false;
            i.Enabled = false;
            //plansza c
            j.Enabled = false;
            k.Enabled = false;
            l.Enabled = false;
            m.Enabled = false;
            n.Enabled = false;
            o.Enabled = false;
            p.Enabled = false;
            r.Enabled = false;
            s.Enabled = false;
            //plansza d
            t.Enabled = false;
            u.Enabled = false;
            w.Enabled = false;
            y.Enabled = false;
            z.Enabled = false;
            aa.Enabled = false;
            ab.Enabled = false;
            ac.Enabled = false;
            ad.Enabled = false;
            //plansza f
            an.Enabled = false;
            ao.Enabled = false;
            ap.Enabled = false;
            ar.Enabled = false;
            ass.Enabled = false;
            at.Enabled = false;
            au.Enabled = false;
            aw.Enabled = false;
            ay.Enabled = false;
            //plansza g
            az.Enabled = false;
            ba.Enabled = false;
            bb.Enabled = false;
            bc.Enabled = false;
            bd.Enabled = false;
            be.Enabled = false;
            bf.Enabled = false;
            bg.Enabled = false;
            bh.Enabled = false;
            //plansza h
            bi.Enabled = false;
            bj.Enabled = false;
            bk.Enabled = false;
            bl.Enabled = false;
            bm.Enabled = false;
            bn.Enabled = false;
            bo.Enabled = false;
            bp.Enabled = false;
            br.Enabled = false;
            //plansza i
            bs.Enabled = false;
            bt.Enabled = false;
            bu.Enabled = false;
            bw.Enabled = false;
            by.Enabled = false;
            bz.Enabled = false;
            ca.Enabled = false;
            cb.Enabled = false;
            cc.Enabled = false;

            Odblokowanie();
        }  // działa dobrze


        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sprZwyciezce()
        {
            bool zwyciezca = false;
            bool remis = false;

            //poziom plansza e

            if ((e1.Text == e2.Text) && (e2.Text == e3.Text) && e1.Text != "")
                zwyciezca = true;
            else if ((e4.Text == e5.Text) && (e5.Text == e6.Text) && e4.Text != "")
                zwyciezca = true;
            else if ((e7.Text == e8.Text) && (e8.Text == e9.Text) && e7.Text != "")
                zwyciezca = true;

            //pion plansza e

            else if ((e1.Text == e4.Text) && (e4.Text == e7.Text) && e1.Text != "")
                zwyciezca = true;
            else if ((e2.Text == e5.Text) && (e5.Text == e8.Text) && e2.Text != "")
                zwyciezca = true;
            else if ((e3.Text == e6.Text) && (e6.Text == e9.Text) && e3.Text != "")
                zwyciezca = true;

            //ukos plansza e

            else if ((e1.Text == e5.Text) && (e5.Text == e9.Text) && e1.Text != "")
                zwyciezca = true;
            else if ((e3.Text == e5.Text) && (e5.Text == e7.Text) && e3.Text != "")
                zwyciezca = true;
            //spr całosc e
            else if (e1.Text != "" && e2.Text != "" && e3.Text != "" && e4.Text != "" && e5.Text != "" && e6.Text != "" && e7.Text != "" && e8.Text != "" && e9.Text != "")
            {
                remis = true;
            }

            //poziom plansza a 

            else if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && a1.Text != "")
                zwyciezca = true;
            else if ((a4.Text == a5.Text) && (a5.Text == a6.Text) && a4.Text != "")
                zwyciezca = true;
            else if ((a7.Text == a8.Text) && (a8.Text == a9.Text) && a7.Text != "")
                zwyciezca = true;

            // pion plansza a

            else if ((a1.Text == a4.Text) && (a4.Text == a7.Text) && a1.Text != "")
                zwyciezca = true;
            else if ((a2.Text == a5.Text) && (a5.Text == a8.Text) && a2.Text != "")
                zwyciezca = true;
            else if ((a3.Text == a6.Text) && (a6.Text == a9.Text) && a3.Text != "")
                zwyciezca = true;

            //ukos plansza a

            else if ((a1.Text == a5.Text) && (a5.Text == a9.Text) && a1.Text != "")
                zwyciezca = true;
            else if ((a3.Text == a5.Text) && (a5.Text == a7.Text) && a3.Text != "")
                zwyciezca = true;
            // spr całość a
            else if (a1.Text != "" && a2.Text != "" && a3.Text != "" && a4.Text != "" && a5.Text != "" && a6.Text != "" && a7.Text != "" && a8.Text != "" && a9.Text != "")
            {
                remis = true;
            }


            //poziom plansza b

            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b1.Text != "")
                zwyciezca = true;
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && b4.Text != "")
                zwyciezca = true;
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && b7.Text != "")
                zwyciezca = true;

            //pion plansza b

            else if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && b1.Text != "")
                zwyciezca = true;
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && b2.Text != "")
                zwyciezca = true;
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && b3.Text != "")
                zwyciezca = true;

            //ukos plansza b

            else if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && b1.Text != "")
                zwyciezca = true;
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && b3.Text != "")
                zwyciezca = true;
            //spr całosc b
            else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "" && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                remis = true;
            }


            //poziom plansza c

            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && c1.Text != "")
                zwyciezca = true;
            else if ((c4.Text == c5.Text) && (c5.Text == c6.Text) && c4.Text != "")
                zwyciezca = true;
            else if ((c7.Text == c8.Text) && (c8.Text == c9.Text) && c7.Text != "")
                zwyciezca = true;

            //pion plansza c

            else if ((c1.Text == c4.Text) && (c4.Text == c7.Text) && c1.Text != "")
                zwyciezca = true;
            else if ((c2.Text == c5.Text) && (c5.Text == c8.Text) && c2.Text != "")
                zwyciezca = true;
            else if ((c3.Text == c6.Text) && (c6.Text == c9.Text) && c3.Text != "")
                zwyciezca = true;

            //ukos plansza c

            else if ((c1.Text == c5.Text) && (c5.Text == c9.Text) && c1.Text != "")
                zwyciezca = true;
            else if ((c3.Text == c5.Text) && (c5.Text == c7.Text) && c3.Text != "")
                zwyciezca = true;
            //spr calosc c
            else if (c1.Text != "" && c2.Text != "" && c3.Text != "" && c4.Text != "" && c5.Text != "" && c6.Text != "" && c7.Text != "" && c8.Text != "" && c9.Text != "")
            {
                remis = true;
            }

            // poziom plansza d

            else if ((d1.Text == d2.Text) && (d2.Text == d3.Text) && d1.Text != "")
                zwyciezca = true;
            else if ((d4.Text == d5.Text) && (d5.Text == d6.Text) && d4.Text != "")
                zwyciezca = true;
            else if ((d7.Text == d8.Text) && (d8.Text == d9.Text) && d7.Text != "")
                zwyciezca = true;

            //pion plansza d

            else if ((d1.Text == d4.Text) && (d4.Text == d7.Text) && d1.Text != "")
                zwyciezca = true;
            else if ((d2.Text == d5.Text) && (d5.Text == d8.Text) && d2.Text != "")
                zwyciezca = true;
            else if ((d3.Text == d6.Text) && (d6.Text == d9.Text) && d3.Text != "")
                zwyciezca = true;

            //ukos plansza d

            else if ((d1.Text == d5.Text) && (d5.Text == d9.Text) && d1.Text != "")
                zwyciezca = true;
            else if ((d3.Text == d5.Text) && (d5.Text == d7.Text) && d3.Text != "")
                zwyciezca = true;
            //spr calosc d
            else if (d1.Text != "" && d2.Text != "" && d3.Text != "" && d4.Text != "" && d5.Text != "" && d6.Text != "" && d7.Text != "" && d8.Text != "" && d9.Text != "")
            {
                remis = true;
            }

            // poziom plansza f

            else if ((f1.Text == f2.Text) && (f2.Text == f3.Text) && f1.Text != "")
                zwyciezca = true;
            else if ((f4.Text == f5.Text) && (f5.Text == f6.Text) && f4.Text != "")
                zwyciezca = true;
            else if ((f7.Text == f8.Text) && (f8.Text == f9.Text) && f7.Text != "")
                zwyciezca = true;

            //pion plansza f

            else if ((f1.Text == f4.Text) && (f4.Text == f7.Text) && f1.Text != "")
                zwyciezca = true;
            else if ((f2.Text == f5.Text) && (f5.Text == f8.Text) && f2.Text != "")
                zwyciezca = true;
            else if ((f3.Text == f6.Text) && (f6.Text == f9.Text) && f3.Text != "")
                zwyciezca = true;

            //ukos plansza f

            else if ((f1.Text == f5.Text) && (f5.Text == f9.Text) && f1.Text != "")
                zwyciezca = true;
            else if ((f3.Text == f5.Text) && (f5.Text == f7.Text) && f3.Text != "")
                zwyciezca = true;
            //spr calosc f
            else if (f1.Text != "" && f2.Text != "" && f3.Text != "" && f4.Text != "" && f5.Text != "" && f6.Text != "" && f7.Text != "" && f8.Text != "" && f9.Text != "")
            {
                remis = true;
            }

            // poziom plansza g

            else if ((g1.Text == g2.Text) && (g2.Text == g3.Text) && g1.Text != "")
                zwyciezca = true;
            else if ((g4.Text == g5.Text) && (g5.Text == g6.Text) && g4.Text != "")
                zwyciezca = true;
            else if ((g7.Text == g8.Text) && (g8.Text == g9.Text) && g7.Text != "")
                zwyciezca = true;

            //pion plansza g

            else if ((g1.Text == g4.Text) && (g4.Text == g7.Text) && g1.Text != "")
                zwyciezca = true;
            else if ((g2.Text == g5.Text) && (g5.Text == g8.Text) && g2.Text != "")
                zwyciezca = true;
            else if ((g3.Text == g6.Text) && (g6.Text == g9.Text) && g3.Text != "")
                zwyciezca = true;

            //ukos plansza g

            else if ((g1.Text == g5.Text) && (g5.Text == g9.Text) && g1.Text != "")
                zwyciezca = true;
            else if ((g3.Text == g5.Text) && (g5.Text == g7.Text) && g3.Text != "")
                zwyciezca = true;
            //spr calosc g
            else if (g1.Text != "" && g2.Text != "" && g3.Text != "" && g4.Text != "" && g5.Text != "" && g6.Text != "" && g7.Text != "" && g8.Text != "" && g9.Text != "")
            {
                remis = true;
            }

            // poziom plansza h

            else if ((h1.Text == h2.Text) && (h2.Text == h3.Text) && h1.Text != "")
                zwyciezca = true;
            else if ((h4.Text == h5.Text) && (h5.Text == h6.Text) && h4.Text != "")
                zwyciezca = true;
            else if ((h7.Text == h8.Text) && (h8.Text == h9.Text) && h7.Text != "")
                zwyciezca = true;

            //pion plansza h

            else if ((h1.Text == h4.Text) && (h4.Text == h7.Text) && h1.Text != "")
                zwyciezca = true;
            else if ((h2.Text == h5.Text) && (h5.Text == h8.Text) && h2.Text != "")
                zwyciezca = true;
            else if ((h3.Text == h6.Text) && (h6.Text == h9.Text) && h3.Text != "")
                zwyciezca = true;

            //ukos plansza h

            else if ((h1.Text == h5.Text) && (h5.Text == h9.Text) && h1.Text != "")
                zwyciezca = true;
            else if ((h3.Text == h5.Text) && (h5.Text == h7.Text) && h3.Text != "")
                zwyciezca = true;
            // spr calosc h
            else if (h1.Text != "" && h2.Text != "" && h3.Text != "" && h4.Text != "" && h5.Text != "" && h6.Text != "" && h7.Text != "" && h8.Text != "" && h9.Text != "")
            {
                remis = true;
            }

            //poziom plansza i

            else if ((i1.Text == i2.Text) && (i2.Text == i3.Text) && i1.Text != "")
                zwyciezca = true;
            else if ((i4.Text == i5.Text) && (i5.Text == i6.Text) && i4.Text != "")
                zwyciezca = true;
            else if ((i7.Text == i8.Text) && (i8.Text == i9.Text) && i7.Text != "")
                zwyciezca = true;

            //pion plansza i

            else if ((i1.Text == i4.Text) && (i4.Text == i7.Text) && i1.Text != "")
                zwyciezca = true;
            else if ((i2.Text == i5.Text) && (i5.Text == i8.Text) && i2.Text != "")
                zwyciezca = true;
            else if ((i3.Text == i6.Text) && (i6.Text == i9.Text) && i3.Text != "")
                zwyciezca = true;

            //ukos plansza i

            else if ((i1.Text == i5.Text) && (i5.Text == i9.Text) && i1.Text != "")
                zwyciezca = true;
            else if ((i3.Text == i5.Text) && (i5.Text == i7.Text) && i3.Text != "")
                zwyciezca = true;
            //spr calosc i
            else if (i1.Text != "" && i2.Text != "" && i3.Text != "" && i4.Text != "" && i5.Text != "" && i6.Text != "" && i7.Text != "" && i8.Text != "" && i9.Text != "")
            {
                remis = true;
            }



            if (zwyciezca)
            {
                wylPrzyciski();
                String wygrany = " ";
                if (turn)
                    wygrany = "O";
                else
                    wygrany = "X";


                MessageBox.Show(wygrany + "  Wygral", "Gratulacje!");
            }
            else
            {
                if (remis)
                    MessageBox.Show("gra nie roztrzygnienta", "Uwaga!");
            }

        }

        private void wylPrzyciski()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            }
            catch { }


        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            turn_count++;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    start_blok_plansza_e();

                }
            }
            catch { }
        }

        private void graZKomputeremToolStripMenuItem_Click(object sender, EventArgs e)
        {
            przeciwko_komputerowi = true;
            ruch_komputera();
        }

        private void ruch_komputera()
        {

            Button move = null;
            move = look_for_win_or_block("O"); //sprawdz wygraną
            if (move == null)
            {
                move = look_for_win_or_block("X"); //szukaj blokady
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

            move.PerformClick();
        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if
            //for () { }
            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (a1.Text == "O")
            {
                if (a3.Text == "")
                    return a3;
                if (a7.Text == "")
                    return a7;
                if (a9.Text == "")
                    return a9;
            }

            if (a3.Text == "O")
            {
                if (a1.Text == "")
                    return a1;
                if (a9.Text == "")
                    return a9;
                if (a7.Text == "")
                    return a7;
            }

            if (a9.Text == "O")
            {
                if (a1.Text == "")
                    return a1;
                if (a3.Text == "")
                    return a3;
                if (a7.Text == "")
                    return a7;
            }

            if (a7.Text == "O")
            {
                if (a1.Text == "")
                    return a1;
                if (a3.Text == "")
                    return a3;
                if (a9.Text == "")
                    return a9;
            }

            if (a1.Text == "")
                return a1;
            if (a3.Text == "")
                return a3;
            if (a7.Text == "")
                return a7;
            if (a9.Text == "")
                return a9;
            //b
            if (b1.Text == "O")
            {
                if (b3.Text == "")
                    return b3;
                if (b7.Text == "")
                    return b7;
                if (b9.Text == "")
                    return b9;
            }

            if (b3.Text == "O")
            {
                if (b1.Text == "")
                    return b1;
                if (b9.Text == "")
                    return b9;
                if (b7.Text == "")
                    return b7;
            }

            if (b9.Text == "O")
            {
                if (b1.Text == "")
                    return b1;
                if (b3.Text == "")
                    return b3;
                if (b7.Text == "")
                    return b7;
            }

            if (b7.Text == "O")
            {
                if (b1.Text == "")
                    return b1;
                if (b3.Text == "")
                    return b3;
                if (b9.Text == "")
                    return b9;
            }

            if (b1.Text == "")
                return b1;
            if (b3.Text == "")
                return b3;
            if (b7.Text == "")
                return b7;
            if (b9.Text == "")
                return b9;

            //c
            if (c1.Text == "O")
            {
                if (c3.Text == "")
                    return c3;
                if (c7.Text == "")
                    return c7;
                if (c9.Text == "")
                    return c9;
            }

            if (c3.Text == "O")
            {
                if (c1.Text == "")
                    return c1;
                if (c9.Text == "")
                    return c9;
                if (c7.Text == "")
                    return c7;
            }

            if (c9.Text == "O")
            {
                if (c1.Text == "")
                    return c1;
                if (c3.Text == "")
                    return c3;
                if (c7.Text == "")
                    return c7;
            }

            if (c7.Text == "O")
            {
                if (c1.Text == "")
                    return c1;
                if (c3.Text == "")
                    return c3;
                if (c9.Text == "")
                    return c9;
            }

            if (c1.Text == "")
                return c1;
            if (c3.Text == "")
                return c3;
            if (c7.Text == "")
                return c7;
            if (c9.Text == "")
                return c9;

            //d
            if (d1.Text == "O")
            {
                if (d3.Text == "")
                    return d3;
                if (d7.Text == "")
                    return d7;
                if (d9.Text == "")
                    return d9;
            }

            if (d3.Text == "O")
            {
                if (d1.Text == "")
                    return d1;
                if (d9.Text == "")
                    return d9;
                if (d7.Text == "")
                    return d7;
            }

            if (d9.Text == "O")
            {
                if (d1.Text == "")
                    return d1;
                if (d3.Text == "")
                    return d3;
                if (d7.Text == "")
                    return d7;
            }

            if (d7.Text == "O")
            {
                if (d1.Text == "")
                    return d1;
                if (d3.Text == "")
                    return d3;
                if (d9.Text == "")
                    return d9;
            }

            if (d1.Text == "")
                return d1;
            if (d3.Text == "")
                return d3;
            if (d7.Text == "")
                return d7;
            if (d9.Text == "")
                return d9;

            //e
            if (e1.Text == "O")
            {
                if (e3.Text == "")
                    return e3;
                if (e7.Text == "")
                    return e7;
                if (e9.Text == "")
                    return e9;
            }

            if (e3.Text == "O")
            {
                if (e1.Text == "")
                    return e1;
                if (e9.Text == "")
                    return e9;
                if (e7.Text == "")
                    return e7;
            }

            if (e9.Text == "O")
            {
                if (e1.Text == "")
                    return e1;
                if (e3.Text == "")
                    return e3;
                if (e7.Text == "")
                    return e7;
            }

            if (e7.Text == "O")
            {
                if (e1.Text == "")
                    return e1;
                if (e3.Text == "")
                    return e3;
                if (e9.Text == "")
                    return e9;
            }

            if (e1.Text == "")
                return e1;
            if (e3.Text == "")
                return e3;
            if (e7.Text == "")
                return e7;
            if (e9.Text == "")
                return e9;

            //f

            if (f1.Text == "O")
            {
                if (f3.Text == "")
                    return f3;
                if (f7.Text == "")
                    return f7;
                if (f9.Text == "")
                    return f9;
            }

            if (f3.Text == "O")
            {
                if (f1.Text == "")
                    return f1;
                if (f9.Text == "")
                    return f9;
                if (f7.Text == "")
                    return f7;
            }

            if (f9.Text == "O")
            {
                if (f1.Text == "")
                    return f1;
                if (f3.Text == "")
                    return f3;
                if (f7.Text == "")
                    return f7;
            }

            if (f7.Text == "O")
            {
                if (f1.Text == "")
                    return f1;
                if (f3.Text == "")
                    return f3;
                if (f9.Text == "")
                    return f9;
            }

            if (f1.Text == "")
                return f1;
            if (f3.Text == "")
                return f3;
            if (f7.Text == "")
                return f7;
            if (f9.Text == "")
                return f9;

            // g

            if (g1.Text == "O")
            {
                if (g3.Text == "")
                    return g3;
                if (g7.Text == "")
                    return g7;
                if (g9.Text == "")
                    return g9;
            }

            if (g3.Text == "O")
            {
                if (g1.Text == "")
                    return g1;
                if (g9.Text == "")
                    return g9;
                if (g7.Text == "")
                    return g7;
            }

            if (g9.Text == "O")
            {
                if (g1.Text == "")
                    return g1;
                if (g3.Text == "")
                    return g3;
                if (g7.Text == "")
                    return g7;
            }

            if (g7.Text == "O")
            {
                if (g1.Text == "")
                    return g1;
                if (g3.Text == "")
                    return g3;
                if (g9.Text == "")
                    return g9;
            }

            if (g1.Text == "")
                return g1;
            if (g3.Text == "")
                return g3;
            if (g7.Text == "")
                return g7;
            if (g9.Text == "")
                return g9;

            //h

            if (h1.Text == "O")
            {
                if (h3.Text == "")
                    return h3;
                if (h7.Text == "")
                    return h7;
                if (h9.Text == "")
                    return h9;
            }

            if (h3.Text == "O")
            {
                if (h1.Text == "")
                    return h1;
                if (h9.Text == "")
                    return h9;
                if (h7.Text == "")
                    return h7;
            }

            if (h9.Text == "O")
            {
                if (h1.Text == "")
                    return h1;
                if (h3.Text == "")
                    return h3;
                if (h7.Text == "")
                    return h7;
            }

            if (h7.Text == "O")
            {
                if (h1.Text == "")
                    return h1;
                if (h3.Text == "")
                    return h3;
                if (h9.Text == "")
                    return h9;
            }

            if (h1.Text == "")
                return h1;
            if (h3.Text == "")
                return h3;
            if (h7.Text == "")
                return h7;
            if (h9.Text == "")
                return h9;

            //i

            if (i1.Text == "O")
            {
                if (i3.Text == "")
                    return i3;
                if (i7.Text == "")
                    return i7;
                if (i9.Text == "")
                    return i9;
            }

            if (i3.Text == "O")
            {
                if (i1.Text == "")
                    return i1;
                if (i9.Text == "")
                    return i9;
                if (i7.Text == "")
                    return i7;
            }

            if (i9.Text == "O")
            {
                if (i1.Text == "")
                    return i1;
                if (i3.Text == "")
                    return i3;
                if (i7.Text == "")
                    return i7;
            }

            if (i7.Text == "O")
            {
                if (i1.Text == "")
                    return i1;
                if (i3.Text == "")
                    return i3;
                if (i9.Text == "")
                    return i9;
            }

            if (i1.Text == "")
                return i1;
            if (i3.Text == "")
                return i3;
            if (i7.Text == "")
                return i7;
            if (i9.Text == "")
                return i9;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);

            //poziom a

            if ((a1.Text == mark) && (a2.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a2.Text == mark) && (a3.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (a3.Text == mark) && (a2.Text == ""))
                return a2;

            if ((a4.Text == mark) && (a5.Text == mark) && (a6.Text == ""))
                return a6;
            if ((a5.Text == mark) && (a6.Text == mark) && (a4.Text == ""))
                return a4;
            if ((a4.Text == mark) && (a6.Text == mark) && (a5.Text == ""))
                return a5;

            if ((a7.Text == mark) && (a8.Text == mark) && (a9.Text == ""))
                return a9;
            if ((a8.Text == mark) && (a9.Text == mark) && (a7.Text == ""))
                return a7;
            if ((a7.Text == mark) && (a9.Text == mark) && (a8.Text == ""))
                return a8;

            //pion a

            if ((a1.Text == mark) && (a4.Text == mark) && (a7.Text == ""))
                return a7;
            if ((a4.Text == mark) && (a7.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a7.Text == mark) && (a1.Text == mark) && (a4.Text == ""))
                return a4;

            if ((a2.Text == mark) && (a5.Text == mark) && (a8.Text == ""))
                return a8;
            if ((a5.Text == mark) && (a8.Text == mark) && (a2.Text == ""))
                return a2;
            if ((a2.Text == mark) && (a8.Text == mark) && (a5.Text == ""))
                return a5;

            if ((a3.Text == mark) && (a6.Text == mark) && (a9.Text == ""))
                return a9;
            if ((a6.Text == mark) && (a9.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a3.Text == mark) && (a9.Text == mark) && (a8.Text == ""))
                return a8;

            //ukos a
            if ((a1.Text == mark) && (a5.Text == mark) && (a9.Text == ""))
                return a9;
            if ((a5.Text == mark) && (a9.Text == mark) && (a1.Text == ""))
                return a1;
            if ((a1.Text == mark) && (a9.Text == mark) && (a5.Text == ""))
                return a5;

            if ((a3.Text == mark) && (a5.Text == mark) && (a7.Text == ""))
                return a7;
            if ((a5.Text == mark) && (a7.Text == mark) && (a3.Text == ""))
                return a3;
            if ((a3.Text == mark) && (a7.Text == mark) && (a5.Text == ""))
                return a5;
            // b
            //poziom b

            if ((b1.Text == mark) && (b2.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b2.Text == mark) && (b3.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b1.Text == mark) && (b3.Text == mark) && (b2.Text == ""))
                return b2;

            if ((b4.Text == mark) && (b5.Text == mark) && (b6.Text == ""))
                return b6;
            if ((b5.Text == mark) && (b6.Text == mark) && (b4.Text == ""))
                return b4;
            if ((b4.Text == mark) && (b6.Text == mark) && (b5.Text == ""))
                return b5;

            if ((b7.Text == mark) && (b8.Text == mark) && (b9.Text == ""))
                return b9;
            if ((b8.Text == mark) && (b9.Text == mark) && (b7.Text == ""))
                return b7;
            if ((b7.Text == mark) && (b9.Text == mark) && (b8.Text == ""))
                return a8;

            //pion b

            if ((b1.Text == mark) && (b4.Text == mark) && (b7.Text == ""))
                return b7;
            if ((b4.Text == mark) && (b7.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b7.Text == mark) && (b1.Text == mark) && (b4.Text == ""))
                return b4;

            if ((b2.Text == mark) && (b5.Text == mark) && (b8.Text == ""))
                return b8;
            if ((b5.Text == mark) && (b8.Text == mark) && (b2.Text == ""))
                return b2;
            if ((b2.Text == mark) && (b8.Text == mark) && (b5.Text == ""))
                return b5;

            if ((b3.Text == mark) && (b6.Text == mark) && (b9.Text == ""))
                return b9;
            if ((b6.Text == mark) && (b9.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b3.Text == mark) && (b9.Text == mark) && (b8.Text == ""))
                return b8;

            //ukos b
            if ((b1.Text == mark) && (b5.Text == mark) && (b9.Text == ""))
                return b9;
            if ((b5.Text == mark) && (b9.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b1.Text == mark) && (b9.Text == mark) && (b5.Text == ""))
                return b5;

            if ((b3.Text == mark) && (b5.Text == mark) && (b7.Text == ""))
                return b7;
            if ((b5.Text == mark) && (b7.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b3.Text == mark) && (b7.Text == mark) && (b5.Text == ""))
                return b5;

            //c
            //poziom c

            if ((c1.Text == mark) && (c2.Text == mark) && (c3.Text == ""))
                return c3;
            if ((c2.Text == mark) && (c3.Text == mark) && (c1.Text == ""))
                return c1;
            if ((c1.Text == mark) && (c3.Text == mark) && (c2.Text == ""))
                return c2;

            if ((c4.Text == mark) && (c5.Text == mark) && (c6.Text == ""))
                return c6;
            if ((c5.Text == mark) && (c6.Text == mark) && (c4.Text == ""))
                return c4;
            if ((c4.Text == mark) && (c6.Text == mark) && (c5.Text == ""))
                return c5;

            if ((c7.Text == mark) && (c8.Text == mark) && (c9.Text == ""))
                return c9;
            if ((c8.Text == mark) && (c9.Text == mark) && (c7.Text == ""))
                return c7;
            if ((c7.Text == mark) && (c9.Text == mark) && (c8.Text == ""))
                return c8;

            //pion c

            if ((c1.Text == mark) && (c4.Text == mark) && (c7.Text == ""))
                return c7;
            if ((c4.Text == mark) && (c7.Text == mark) && (c1.Text == ""))
                return c1;
            if ((c7.Text == mark) && (c1.Text == mark) && (c4.Text == ""))
                return c4;

            if ((c2.Text == mark) && (c5.Text == mark) && (c8.Text == ""))
                return c8;
            if ((c5.Text == mark) && (c8.Text == mark) && (c2.Text == ""))
                return a2;
            if ((c2.Text == mark) && (c8.Text == mark) && (c5.Text == ""))
                return c5;

            if ((c3.Text == mark) && (c6.Text == mark) && (c9.Text == ""))
                return c9;
            if ((c6.Text == mark) && (c9.Text == mark) && (c3.Text == ""))
                return c3;
            if ((c3.Text == mark) && (c9.Text == mark) && (c8.Text == ""))
                return c8;

            //ukos c
            if ((c1.Text == mark) && (c5.Text == mark) && (c9.Text == ""))
                return c9;
            if ((c5.Text == mark) && (c9.Text == mark) && (c1.Text == ""))
                return c1;
            if ((c1.Text == mark) && (c9.Text == mark) && (c5.Text == ""))
                return c5;

            if ((c3.Text == mark) && (c5.Text == mark) && (c7.Text == ""))
                return c7;
            if ((c5.Text == mark) && (c7.Text == mark) && (c3.Text == ""))
                return c3;
            if ((c3.Text == mark) && (c7.Text == mark) && (c5.Text == ""))
                return c5;

            //d 

            //poziom d

            if ((d1.Text == mark) && (d2.Text == mark) && (d3.Text == ""))
                return d3;
            if ((d2.Text == mark) && (d3.Text == mark) && (d1.Text == ""))
                return d1;
            if ((d1.Text == mark) && (d3.Text == mark) && (d2.Text == ""))
                return d2;

            if ((d4.Text == mark) && (d5.Text == mark) && (d6.Text == ""))
                return d6;
            if ((d5.Text == mark) && (d6.Text == mark) && (d4.Text == ""))
                return d4;
            if ((d4.Text == mark) && (d6.Text == mark) && (d5.Text == ""))
                return d5;

            if ((d7.Text == mark) && (d8.Text == mark) && (d9.Text == ""))
                return d9;
            if ((d8.Text == mark) && (d9.Text == mark) && (d7.Text == ""))
                return d7;
            if ((d7.Text == mark) && (d9.Text == mark) && (d8.Text == ""))
                return d8;

            //pion d

            if ((d1.Text == mark) && (d4.Text == mark) && (d7.Text == ""))
                return d7;
            if ((d4.Text == mark) && (d7.Text == mark) && (d1.Text == ""))
                return d1;
            if ((d7.Text == mark) && (d1.Text == mark) && (d4.Text == ""))
                return d4;

            if ((d2.Text == mark) && (d5.Text == mark) && (d8.Text == ""))
                return d8;
            if ((d5.Text == mark) && (d8.Text == mark) && (d2.Text == ""))
                return d2;
            if ((d2.Text == mark) && (d8.Text == mark) && (d5.Text == ""))
                return a5;

            if ((d3.Text == mark) && (d6.Text == mark) && (d9.Text == ""))
                return d9;
            if ((d6.Text == mark) && (d9.Text == mark) && (d3.Text == ""))
                return d3;
            if ((d3.Text == mark) && (d9.Text == mark) && (d8.Text == ""))
                return d8;

            //ukos d
            if ((d1.Text == mark) && (d5.Text == mark) && (d9.Text == ""))
                return d9;
            if ((d5.Text == mark) && (d9.Text == mark) && (d1.Text == ""))
                return d1;
            if ((d1.Text == mark) && (d9.Text == mark) && (d5.Text == ""))
                return d5;

            if ((d3.Text == mark) && (d5.Text == mark) && (d7.Text == ""))
                return d7;
            if ((d5.Text == mark) && (d7.Text == mark) && (d3.Text == ""))
                return d3;
            if ((d3.Text == mark) && (d7.Text == mark) && (d5.Text == ""))
                return d5;

            //e
            //poziom e

            if ((e1.Text == mark) && (e2.Text == mark) && (e3.Text == ""))
                return e3;
            if ((e2.Text == mark) && (e3.Text == mark) && (e1.Text == ""))
                return e1;
            if ((e1.Text == mark) && (e3.Text == mark) && (e2.Text == ""))
                return e2;

            if ((e4.Text == mark) && (e5.Text == mark) && (e6.Text == ""))
                return e6;
            if ((e5.Text == mark) && (e6.Text == mark) && (e4.Text == ""))
                return e4;
            if ((e4.Text == mark) && (e6.Text == mark) && (e5.Text == ""))
                return e5;

            if ((e7.Text == mark) && (e8.Text == mark) && (e9.Text == ""))
                return e9;
            if ((e8.Text == mark) && (e9.Text == mark) && (e7.Text == ""))
                return e7;
            if ((e7.Text == mark) && (e9.Text == mark) && (e8.Text == ""))
                return e8;

            //pion e

            if ((e1.Text == mark) && (e4.Text == mark) && (e7.Text == ""))
                return e7;
            if ((e4.Text == mark) && (e7.Text == mark) && (e1.Text == ""))
                return e1;
            if ((e7.Text == mark) && (e1.Text == mark) && (e4.Text == ""))
                return e4;

            if ((e2.Text == mark) && (e5.Text == mark) && (e8.Text == ""))
                return e8;
            if ((e5.Text == mark) && (e8.Text == mark) && (e2.Text == ""))
                return e2;
            if ((e2.Text == mark) && (e8.Text == mark) && (e5.Text == ""))
                return e5;

            if ((e3.Text == mark) && (e6.Text == mark) && (e9.Text == ""))
                return e9;
            if ((e6.Text == mark) && (e9.Text == mark) && (e3.Text == ""))
                return e3;
            if ((e3.Text == mark) && (e9.Text == mark) && (e8.Text == ""))
                return e8;

            //ukos e
            if ((e1.Text == mark) && (e5.Text == mark) && (e9.Text == ""))
                return e9;
            if ((e5.Text == mark) && (e9.Text == mark) && (e1.Text == ""))
                return e1;
            if ((e1.Text == mark) && (e9.Text == mark) && (e5.Text == ""))
                return e5;

            if ((e3.Text == mark) && (e5.Text == mark) && (e7.Text == ""))
                return e7;
            if ((e5.Text == mark) && (e7.Text == mark) && (e3.Text == ""))
                return e3;
            if ((e3.Text == mark) && (e7.Text == mark) && (e5.Text == ""))
                return e5;

            // f
            //poziom f

            if ((f1.Text == mark) && (f2.Text == mark) && (f3.Text == ""))
                return f3;
            if ((f2.Text == mark) && (f3.Text == mark) && (f1.Text == ""))
                return f1;
            if ((f1.Text == mark) && (f3.Text == mark) && (f2.Text == ""))
                return f2;

            if ((f4.Text == mark) && (f5.Text == mark) && (f6.Text == ""))
                return f6;
            if ((f5.Text == mark) && (f6.Text == mark) && (f4.Text == ""))
                return f4;
            if ((f4.Text == mark) && (f6.Text == mark) && (f5.Text == ""))
                return f5;

            if ((f7.Text == mark) && (f8.Text == mark) && (f9.Text == ""))
                return f9;
            if ((f8.Text == mark) && (f9.Text == mark) && (f7.Text == ""))
                return f7;
            if ((f7.Text == mark) && (f9.Text == mark) && (f8.Text == ""))
                return f8;

            //pion f

            if ((f1.Text == mark) && (f4.Text == mark) && (f7.Text == ""))
                return f7;
            if ((f4.Text == mark) && (f7.Text == mark) && (f1.Text == ""))
                return f1;
            if ((f7.Text == mark) && (f1.Text == mark) && (f4.Text == ""))
                return f4;

            if ((f2.Text == mark) && (f5.Text == mark) && (f8.Text == ""))
                return f8;
            if ((f5.Text == mark) && (f8.Text == mark) && (f2.Text == ""))
                return f2;
            if ((f2.Text == mark) && (f8.Text == mark) && (f5.Text == ""))
                return f5;

            if ((f3.Text == mark) && (f6.Text == mark) && (f9.Text == ""))
                return f9;
            if ((f6.Text == mark) && (f9.Text == mark) && (f3.Text == ""))
                return f3;
            if ((f3.Text == mark) && (f9.Text == mark) && (f8.Text == ""))
                return f8;

            //ukos f
            if ((f1.Text == mark) && (f5.Text == mark) && (f9.Text == ""))
                return f9;
            if ((f5.Text == mark) && (f9.Text == mark) && (f1.Text == ""))
                return f1;
            if ((f1.Text == mark) && (f9.Text == mark) && (f5.Text == ""))
                return f5;

            if ((f3.Text == mark) && (f5.Text == mark) && (f7.Text == ""))
                return f7;
            if ((f5.Text == mark) && (f7.Text == mark) && (f3.Text == ""))
                return f3;
            if ((f3.Text == mark) && (f7.Text == mark) && (f5.Text == ""))
                return f5;

            //g
            //poziom g

            if ((g1.Text == mark) && (g2.Text == mark) && (g3.Text == ""))
                return g3;
            if ((g2.Text == mark) && (g3.Text == mark) && (g1.Text == ""))
                return g1;
            if ((g1.Text == mark) && (g3.Text == mark) && (g2.Text == ""))
                return g2;

            if ((g4.Text == mark) && (g5.Text == mark) && (g6.Text == ""))
                return g6;
            if ((g5.Text == mark) && (g6.Text == mark) && (g4.Text == ""))
                return g4;
            if ((g4.Text == mark) && (g6.Text == mark) && (g5.Text == ""))
                return g5;

            if ((g7.Text == mark) && (g8.Text == mark) && (g9.Text == ""))
                return g9;
            if ((g8.Text == mark) && (g9.Text == mark) && (g7.Text == ""))
                return g7;
            if ((g7.Text == mark) && (g9.Text == mark) && (g8.Text == ""))
                return g8;

            //pion g

            if ((g1.Text == mark) && (g4.Text == mark) && (g7.Text == ""))
                return g7;
            if ((g4.Text == mark) && (g7.Text == mark) && (g1.Text == ""))
                return g1;
            if ((g7.Text == mark) && (g1.Text == mark) && (g4.Text == ""))
                return g4;

            if ((g2.Text == mark) && (g5.Text == mark) && (g8.Text == ""))
                return g8;
            if ((g5.Text == mark) && (g8.Text == mark) && (g2.Text == ""))
                return g2;
            if ((g2.Text == mark) && (g8.Text == mark) && (g5.Text == ""))
                return g5;

            if ((g3.Text == mark) && (g6.Text == mark) && (g9.Text == ""))
                return g9;
            if ((g6.Text == mark) && (g9.Text == mark) && (g3.Text == ""))
                return g3;
            if ((g3.Text == mark) && (g9.Text == mark) && (g8.Text == ""))
                return g8;

            //ukos g
            if ((g1.Text == mark) && (g5.Text == mark) && (g9.Text == ""))
                return g9;
            if ((g5.Text == mark) && (g9.Text == mark) && (g1.Text == ""))
                return g1;
            if ((g1.Text == mark) && (g9.Text == mark) && (g5.Text == ""))
                return g5;

            if ((g3.Text == mark) && (g5.Text == mark) && (g7.Text == ""))
                return g7;
            if ((g5.Text == mark) && (g7.Text == mark) && (g3.Text == ""))
                return g3;
            if ((g3.Text == mark) && (g7.Text == mark) && (g5.Text == ""))
                return g5;


            // h

            //poziom h

            if ((h1.Text == mark) && (h2.Text == mark) && (h3.Text == ""))
                return h3;
            if ((h2.Text == mark) && (h3.Text == mark) && (h1.Text == ""))
                return h1;
            if ((h1.Text == mark) && (h3.Text == mark) && (h2.Text == ""))
                return h2;

            if ((h4.Text == mark) && (h5.Text == mark) && (h6.Text == ""))
                return h6;
            if ((h5.Text == mark) && (h6.Text == mark) && (h4.Text == ""))
                return h4;
            if ((h4.Text == mark) && (h6.Text == mark) && (h5.Text == ""))
                return h5;

            if ((h7.Text == mark) && (h8.Text == mark) && (h9.Text == ""))
                return h9;
            if ((h8.Text == mark) && (h9.Text == mark) && (h7.Text == ""))
                return h7;
            if ((h7.Text == mark) && (h9.Text == mark) && (h8.Text == ""))
                return h8;

            //pion h

            if ((h1.Text == mark) && (h4.Text == mark) && (h7.Text == ""))
                return h7;
            if ((h4.Text == mark) && (h7.Text == mark) && (h1.Text == ""))
                return h1;
            if ((h7.Text == mark) && (h1.Text == mark) && (h4.Text == ""))
                return h4;

            if ((h2.Text == mark) && (h5.Text == mark) && (h8.Text == ""))
                return h8;
            if ((h5.Text == mark) && (h8.Text == mark) && (h2.Text == ""))
                return h2;
            if ((h2.Text == mark) && (h8.Text == mark) && (h5.Text == ""))
                return h5;

            if ((h3.Text == mark) && (h6.Text == mark) && (h9.Text == ""))
                return h9;
            if ((h6.Text == mark) && (h9.Text == mark) && (h3.Text == ""))
                return h3;
            if ((h3.Text == mark) && (h9.Text == mark) && (h8.Text == ""))
                return h8;

            //ukos h
            if ((h1.Text == mark) && (h5.Text == mark) && (h9.Text == ""))
                return h9;
            if ((h5.Text == mark) && (h9.Text == mark) && (h1.Text == ""))
                return h1;
            if ((h1.Text == mark) && (h9.Text == mark) && (h5.Text == ""))
                return h5;

            if ((h3.Text == mark) && (h5.Text == mark) && (h7.Text == ""))
                return h7;
            if ((h5.Text == mark) && (h7.Text == mark) && (h3.Text == ""))
                return h3;
            if ((h3.Text == mark) && (h7.Text == mark) && (h5.Text == ""))
                return h5;

            //i

            //poziom i

            if ((i1.Text == mark) && (i2.Text == mark) && (i3.Text == ""))
                return i3;
            if ((i2.Text == mark) && (i3.Text == mark) && (i1.Text == ""))
                return i1;
            if ((i1.Text == mark) && (i3.Text == mark) && (i2.Text == ""))
                return i2;

            if ((i4.Text == mark) && (i5.Text == mark) && (i6.Text == ""))
                return i6;
            if ((i5.Text == mark) && (i6.Text == mark) && (i4.Text == ""))
                return i4;
            if ((i4.Text == mark) && (i6.Text == mark) && (i5.Text == ""))
                return i5;

            if ((i7.Text == mark) && (i8.Text == mark) && (i9.Text == ""))
                return i9;
            if ((i8.Text == mark) && (i9.Text == mark) && (i7.Text == ""))
                return i7;
            if ((i7.Text == mark) && (i9.Text == mark) && (i8.Text == ""))
                return i8;

            //pion i

            if ((i1.Text == mark) && (i4.Text == mark) && (i7.Text == ""))
                return i7;
            if ((i4.Text == mark) && (i7.Text == mark) && (i1.Text == ""))
                return i1;
            if ((i7.Text == mark) && (i1.Text == mark) && (i4.Text == ""))
                return i4;

            if ((i2.Text == mark) && (i5.Text == mark) && (i8.Text == ""))
                return i8;
            if ((i5.Text == mark) && (i8.Text == mark) && (i2.Text == ""))
                return i2;
            if ((i2.Text == mark) && (i8.Text == mark) && (i5.Text == ""))
                return i5;

            if ((i3.Text == mark) && (i6.Text == mark) && (i9.Text == ""))
                return i9;
            if ((i6.Text == mark) && (i9.Text == mark) && (i3.Text == ""))
                return i3;
            if ((i3.Text == mark) && (i9.Text == mark) && (i8.Text == ""))
                return i8;

            //ukos i
            if ((i1.Text == mark) && (i5.Text == mark) && (i9.Text == ""))
                return i9;
            if ((i5.Text == mark) && (i9.Text == mark) && (i1.Text == ""))
                return i1;
            if ((i1.Text == mark) && (i9.Text == mark) && (i5.Text == ""))
                return i5;

            if ((i3.Text == mark) && (i5.Text == mark) && (i7.Text == ""))
                return i7;
            if ((i5.Text == mark) && (i7.Text == mark) && (i3.Text == ""))
                return i3;
            if ((i3.Text == mark) && (i7.Text == mark) && (i5.Text == ""))
                return i5;


            return null;
        }

         private Button Odblokowanie() // tutaj nie może być "startu z planszy e 
         {
            turn = true;
            turn_count = 0;
            turn_count++;
            
            // zapomniało mi się o planszy a dlatego napisałam ją na dole xd
            //plansza b
            Button a = b1;
            Button b = b2;
            Button c = b3;
            Button d = b4;
            Button e = b5;
            Button f = b6;
            Button g = b7;
            Button h = b8;
            Button i = b9;
            //plansza c
            Button j = c1;
            Button k = c2;
            Button l = c3;
            Button m = c4;
            Button n = c5;
            Button o = c6;
            Button p = c7;
            Button r = c8;
            Button s = c9;
            //plansza d
            Button t = d1;
            Button u = d2;
            Button w = d3;
            Button y = d4;
            Button z = d5;
            Button aa = d6;
            Button ab = d7;
            Button ac = d8;
            Button ad = d9;
            //plansza e
            Button ae = e1;
            Button af = e2;
            Button ag = e3;
            Button ah = e4;
            Button ai = e5;
            Button aj = e6;
            Button ak = e7;
            Button al = e8;
            Button am = e9;
            //plansza f
            Button an = f1;
            Button ao = f2;
            Button ap = f3;
            Button ar = f4;
            Button ass = f5;
            Button at = f6;
            Button au = f7;
            Button aw = f8;
            Button ay = f9;
            //plansza g
            Button az = g1;
            Button ba = g2;
            Button bb = g3;
            Button bc = g4;
            Button bd = g5;
            Button be = g6;
            Button bf = g7;
            Button bg = g8;
            Button bh = g9;
            //plansza h
            Button bi = h1;
            Button bj = h2;
            Button bk = h3;
            Button bl = h4;
            Button bm = h5;
            Button bn = h6;
            Button bo = h7;
            Button bp = h8;
            Button br = h9;
            //plansza i
            Button bs = i1;
            Button bt = i2;
            Button bu = i3;
            Button bw = i4;
            Button by = i5;
            Button bz = i6;
            Button ca = i7;
            Button cb = i8;
            Button cc = i9;
            //plansza a 
            Button cd = a1;
            Button ce = a2;
            Button cf = a3;
            Button cg = a4;
            Button ch = a5;
            Button ci = a6;
            Button cj = a7;
            Button ck = a8;
            Button cl = a9;

           
            
                // koniec wypiosywanie klawiszy xd 
                //blokada związana z planszą e - stąd zaczynam
                if (e1.Text == "X" | e1.Text == "O")
                {
                //plansa a
                cd.Enabled = true;
                ce.Enabled = true;
                cf.Enabled = true;
                cg.Enabled = true;
                ch.Enabled = true;
                ci.Enabled = true;
                cj.Enabled = true;
                ck.Enabled = true;
                cl.Enabled = true;
                //plansza b
                a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                
                } // koniec if e1
                if (e2.Text == "X" | e2.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                   //plansza b
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                e.Enabled = true;
                f.Enabled = true;
                g.Enabled = true;
                h.Enabled = true;
                i.Enabled = true;
                //plansza c
                j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                }//koniec if e2
                if (e3.Text == "X" | e3.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                //plansza c
                j.Enabled = true;
                k.Enabled = true;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                p.Enabled = true;
                r.Enabled = true;
                s.Enabled = true;
                //plansza d
                t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if e3
                if (e4.Text == "X" | e4.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                //plansza d
                t.Enabled = true;
                u.Enabled = true;
                w.Enabled = true;
                y.Enabled = true;
                z.Enabled = true;
                aa.Enabled = true;
                ab.Enabled = true;
                ac.Enabled = true;
                ad.Enabled = true;
                //plansza e
                ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if e4
                  // tutaj nie ma e5 (środek planszy )
                if (e6.Text == "X" | e6.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                //plansza f
                an.Enabled = true;
                ao.Enabled = true;
                ap.Enabled = true;
                ar.Enabled = true;
                ass.Enabled = true;
                at.Enabled = true;
                au.Enabled = true;
                aw.Enabled = true;
                ay.Enabled = true;
                //plansza g
                az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if e6
                if (e7.Text == "X" | e7.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                //plansza g
                az.Enabled = true;
                ba.Enabled = true;
                bb.Enabled = true;
                bc.Enabled = true;
                bd.Enabled = true;
                be.Enabled = true;
                bf.Enabled = true;
                bg.Enabled = true;
                bh.Enabled = true;
                //plansza h
                bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if e7
                if (e8.Text == "X" | e8.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                //plansza h
                bi.Enabled = true;
                bj.Enabled = true;
                bk.Enabled = true;
                bl.Enabled = true;
                bm.Enabled = true;
                bn.Enabled = true;
                bo.Enabled = true;
                bp.Enabled = true;
                br.Enabled = true;
                //plansza i
                bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if e8
                if (e9.Text == "X" | e9.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                //plansza i
                bs.Enabled = true;
                bt.Enabled = true;
                bu.Enabled = true;
                bw.Enabled = true;
                by.Enabled = true;
                bz.Enabled = true;
                ca.Enabled = true;
                cb.Enabled = true;
                cc.Enabled = true;
            }// koniec if e9


                //blokada związana z planszą a
                //pomijam tutaj klawisz a1(lewt górny róg)
                if (a2.Text == "X" | a2.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                //plansza b
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                e.Enabled = true;
                f.Enabled = true;
                g.Enabled = true;
                h.Enabled = true;
                i.Enabled = true;
                //plansza c
                j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;

                } // koniec if a2
                if (a3.Text == "X" | a3.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                //plansza c
                j.Enabled = true;
                k.Enabled = true;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                p.Enabled = true;
                r.Enabled = true;
                s.Enabled = true;
                //plansza d
                t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if a3
                if (a4.Text == "X" | a4.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                //plansza d
                t.Enabled = true;
                u.Enabled = true;
                w.Enabled = true;
                y.Enabled = true;
                z.Enabled = true;
                aa.Enabled = true;
                ab.Enabled = true;
                ac.Enabled = true;
                ad.Enabled = true;
                //plansza e
                ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if a4
                if (a5.Text == "X" | a5.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                //plansza e
                ae.Enabled = true;
                af.Enabled = true;
                ag.Enabled = true;
                ah.Enabled = true;
                ai.Enabled = true;
                aj.Enabled = true;
                ak.Enabled = true;
                al.Enabled = true;
                am.Enabled = true;
                //plansza f
                an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if a5
                if (a6.Text == "X" | a6.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                //plansza f
                an.Enabled = true;
                ao.Enabled = true;
                ap.Enabled = true;
                ar.Enabled = true;
                ass.Enabled = true;
                at.Enabled = true;
                au.Enabled = true;
                aw.Enabled = true;
                ay.Enabled = true;
                //plansza g
                az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if a6
                if (a7.Text == "X" | a7.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                //plansza g
                az.Enabled = true;
                ba.Enabled = true;
                bb.Enabled = true;
                bc.Enabled = true;
                bd.Enabled = true;
                be.Enabled = true;
                bf.Enabled = true;
                bg.Enabled = true;
                bh.Enabled = true;
                //plansza h
                bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if a7
                if (a8.Text == "X" | a8.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                //plansza h
                bi.Enabled = true;
                bj.Enabled = true;
                bk.Enabled = true;
                bl.Enabled = true;
                bm.Enabled = true;
                bn.Enabled = true;
                bo.Enabled = true;
                bp.Enabled = true;
                br.Enabled = true;
                //plansza i
                bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if a8
                if (a9.Text == "X" | a9.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                //plansza i
                bs.Enabled = true;
                bt.Enabled = true;
                bu.Enabled = true;
                bw.Enabled = true;
                by.Enabled = true;
                bz.Enabled = true;
                ca.Enabled = true;
                cb.Enabled = true;
                cc.Enabled = true;
            } // koniec if a9

                // blokada związana z planszą b
                if (b1.Text == "X" | b1.Text == "O")
                {
                //plansa a
                cd.Enabled = true;
                ce.Enabled = true;
                cf.Enabled = true;
                cg.Enabled = true;
                ch.Enabled = true;
                ci.Enabled = true;
                cj.Enabled = true;
                ck.Enabled = true;
                cl.Enabled = true;
                //plansza b
                a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } //koniec if b1
                  // pomijam tutaj klawisz b2(środek góra)
                if (b3.Text == "X" | b3.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                //plansza c
                j.Enabled = true;
                k.Enabled = true;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                p.Enabled = true;
                r.Enabled = true;
                s.Enabled = true;
                //plansza d
                t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if b3
                if (b4.Text == "X" | b4.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                //plansza d
                t.Enabled = true;
                u.Enabled = true;
                w.Enabled = true;
                y.Enabled = true;
                z.Enabled = true;
                aa.Enabled = true;
                ab.Enabled = true;
                ac.Enabled = true;
                ad.Enabled = true;
                //plansza e
                ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if b4
                if (b5.Text == "X" | b5.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                //plansza e
                ae.Enabled = true;
                af.Enabled = true;
                ag.Enabled = true;
                ah.Enabled = true;
                ai.Enabled = true;
                aj.Enabled = true;
                ak.Enabled = true;
                al.Enabled = true;
                am.Enabled = true;
                //plansza f
                an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if b5
                if (b6.Text == "X" | b6.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                //plansza f
                an.Enabled = true;
                ao.Enabled = true;
                ap.Enabled = true;
                ar.Enabled = true;
                ass.Enabled = true;
                at.Enabled = true;
                au.Enabled = true;
                aw.Enabled = true;
                ay.Enabled = true;
                //plansza g
                az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if b6
                if (b7.Text == "X" | b7.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                //plansza g
                az.Enabled = true;
                ba.Enabled = true;
                bb.Enabled = true;
                bc.Enabled = true;
                bd.Enabled = true;
                be.Enabled = true;
                bf.Enabled = true;
                bg.Enabled = true;
                bh.Enabled = true;
                //plansza h
                bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if b7
                if (b8.Text == "X" | b8.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                //plansza h
                bi.Enabled = true;
                bj.Enabled = true;
                bk.Enabled = true;
                bl.Enabled = true;
                bm.Enabled = true;
                bn.Enabled = true;
                bo.Enabled = true;
                bp.Enabled = true;
                br.Enabled = true;
                //plansza i
                bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if b8
                if (b9.Text == "X" | b9.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                //plansza i
                bs.Enabled = true;
                bt.Enabled = true;
                bu.Enabled = true;
                bw.Enabled = true;
                by.Enabled = true;
                bz.Enabled = true;
                ca.Enabled = true;
                cb.Enabled = true;
                cc.Enabled = true;
            } // koniec if b9

                //blokada związana z planszą c
                if (c1.Text == "X" | c1.Text == "O")
                {
                //plansa a
                cd.Enabled = true;
                ce.Enabled = true;
                cf.Enabled = true;
                cg.Enabled = true;
                ch.Enabled = true;
                ci.Enabled = true;
                cj.Enabled = true;
                ck.Enabled = true;
                cl.Enabled = true;
                //plansza b
                a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if c1
                if (c2.Text == "X" | c2.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                //plansza b
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                e.Enabled = true;
                f.Enabled = true;
                g.Enabled = true;
                h.Enabled = true;
                i.Enabled = true;
                //plansza c
                j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                }//koniec if c2
                 // pomijam tutaj klawisz c3(prwy górny róg)
                if (c4.Text == "X" | c4.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                //plansza d
                t.Enabled = true;
                u.Enabled = true;
                w.Enabled = true;
                y.Enabled = true;
                z.Enabled = true;
                aa.Enabled = true;
                ab.Enabled = true;
                ac.Enabled = true;
                ad.Enabled = true;
                //plansza e
                ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if c4
                if (c5.Text == "X" | c5.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                //plansza e
                ae.Enabled = true;
                af.Enabled = true;
                ag.Enabled = true;
                ah.Enabled = true;
                ai.Enabled = true;
                aj.Enabled = true;
                ak.Enabled = true;
                al.Enabled = true;
                am.Enabled = true;
                //plansza f
                an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if c5
                if (c6.Text == "X" | c6.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                //plansza f
                an.Enabled = true;
                ao.Enabled = true;
                ap.Enabled = true;
                ar.Enabled = true;
                ass.Enabled = true;
                at.Enabled = true;
                au.Enabled = true;
                aw.Enabled = true;
                ay.Enabled = true;
                //plansza g
                az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if c6
                if (c7.Text == "X" | c7.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                //plansza g
                az.Enabled = true;
                ba.Enabled = true;
                bb.Enabled = true;
                bc.Enabled = true;
                bd.Enabled = true;
                be.Enabled = true;
                bf.Enabled = true;
                bg.Enabled = true;
                bh.Enabled = true;
                //plansza h
                bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if c7
                if (c8.Text == "X" | c8.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                //plansza h
                bi.Enabled = true;
                bj.Enabled = true;
                bk.Enabled = true;
                bl.Enabled = true;
                bm.Enabled = true;
                bn.Enabled = true;
                bo.Enabled = true;
                bp.Enabled = true;
                br.Enabled = true;
                //plansza i
                bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if c8
                if (c9.Text == "X" | c9.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                //plansza i
                bs.Enabled = true;
                bt.Enabled = true;
                bu.Enabled = true;
                bw.Enabled = true;
                by.Enabled = true;
                bz.Enabled = true;
                ca.Enabled = true;
                cb.Enabled = true;
                cc.Enabled = true;
            } // koniec if c9

                //blokada związana z planszą d
                if (d1.Text == "X" | d1.Text == "O")
                {
                //plansa a
                cd.Enabled = true;
                ce.Enabled = true;
                cf.Enabled = true;
                cg.Enabled = true;
                ch.Enabled = true;
                ci.Enabled = true;
                cj.Enabled = true;
                ck.Enabled = true;
                cl.Enabled = true;
                //plansza b
                a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if d1
                if (d2.Text == "X" | d2.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                //plansza b
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                e.Enabled = true;
                f.Enabled = true;
                g.Enabled = true;
                h.Enabled = true;
                i.Enabled = true;
                //plansza c
                j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } //koniec if d2
                if (d3.Text == "X" | d3.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                //plansza c
                j.Enabled = true;
                k.Enabled = true;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                p.Enabled = true;
                r.Enabled = true;
                s.Enabled = true;
                //plansza d
                t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if d3
                  // pomijam klawisz d4(lewy środek)
                if (d5.Text == "X" | d5.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                //plansza e
                ae.Enabled = true;
                af.Enabled = true;
                ag.Enabled = true;
                ah.Enabled = true;
                ai.Enabled = true;
                aj.Enabled = true;
                ak.Enabled = true;
                al.Enabled = true;
                am.Enabled = true;
                //plansza f
                an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if d5
                if (d6.Text == "X" | d6.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                //plansza f
                an.Enabled = true;
                ao.Enabled = true;
                ap.Enabled = true;
                ar.Enabled = true;
                ass.Enabled = true;
                at.Enabled = true;
                au.Enabled = true;
                aw.Enabled = true;
                ay.Enabled = true;
                //plansza g
                az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if d6
                if (d7.Text == "X" | d7.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                //plansza g
                az.Enabled = true;
                ba.Enabled = true;
                bb.Enabled = true;
                bc.Enabled = true;
                bd.Enabled = true;
                be.Enabled = true;
                bf.Enabled = true;
                bg.Enabled = true;
                bh.Enabled = true;
                //plansza h
                bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if d7
                if (d8.Text == "X" | d8.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                //plansza h
                bi.Enabled = true;
                bj.Enabled = true;
                bk.Enabled = true;
                bl.Enabled = true;
                bm.Enabled = true;
                bn.Enabled = true;
                bo.Enabled = true;
                bp.Enabled = true;
                br.Enabled = true;
                //plansza i
                bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if d8
                if (d9.Text == "X" | d9.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                //plansza i
                bs.Enabled = true;
                bt.Enabled = true;
                bu.Enabled = true;
                bw.Enabled = true;
                by.Enabled = true;
                bz.Enabled = true;
                ca.Enabled = true;
                cb.Enabled = true;
                cc.Enabled = true;
            } // koniec if d9

                //blokada związana z planszą f
                if (f1.Text == "X" | f1.Text == "O")
                {
                //plansa a
                cd.Enabled = true;
                ce.Enabled = true;
                cf.Enabled = true;
                cg.Enabled = true;
                ch.Enabled = true;
                ci.Enabled = true;
                cj.Enabled = true;
                ck.Enabled = true;
                cl.Enabled = true;
                //plansza b
                a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if f1
                if (f2.Text == "X" | f2.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                //plansza b
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                e.Enabled = true;
                f.Enabled = true;
                g.Enabled = true;
                h.Enabled = true;
                i.Enabled = true;
                //plansza c
                j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } //koniec if f2
                if (f3.Text == "X" | f3.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                //plansza c
                j.Enabled = true;
                k.Enabled = true;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                p.Enabled = true;
                r.Enabled = true;
                s.Enabled = true;
                //plansza d
                t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if f3
                if (f4.Text == "X" | f4.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                //plansza d
                t.Enabled = true;
                u.Enabled = true;
                w.Enabled = true;
                y.Enabled = true;
                z.Enabled = true;
                aa.Enabled = true;
                ab.Enabled = true;
                ac.Enabled = true;
                ad.Enabled = true;
                //plansza e
                ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if f4
                if (f5.Text == "X" | f5.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                //plansza e
                ae.Enabled = true;
                af.Enabled = true;
                ag.Enabled = true;
                ah.Enabled = true;
                ai.Enabled = true;
                aj.Enabled = true;
                ak.Enabled = true;
                al.Enabled = true;
                am.Enabled = true;
                //plansza f
                an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if f5
                  // pomijam klawisz f6(prawy środek)
                if (f7.Text == "X" | f7.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                //plansza g
                az.Enabled = true;
                ba.Enabled = true;
                bb.Enabled = true;
                bc.Enabled = true;
                bd.Enabled = true;
                be.Enabled = true;
                bf.Enabled = true;
                bg.Enabled = true;
                bh.Enabled = true;
                //plansza h
                bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if f7
                if (f8.Text == "X" | f8.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                //plansza h
                bi.Enabled = true;
                bj.Enabled = true;
                bk.Enabled = true;
                bl.Enabled = true;
                bm.Enabled = true;
                bn.Enabled = true;
                bo.Enabled = true;
                bp.Enabled = true;
                br.Enabled = true;
                //plansza i
                bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if f8
                if (f9.Text == "X" | f9.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                //plansza i
                bs.Enabled = true;
                bt.Enabled = true;
                bu.Enabled = true;
                bw.Enabled = true;
                by.Enabled = true;
                bz.Enabled = true;
                ca.Enabled = true;
                cb.Enabled = true;
                cc.Enabled = true;
            } // koniec if f9

                //blokada związana z planszą g
                if (g1.Text == "X" | g1.Text == "O")
                {
                //plansa a
                cd.Enabled = true;
                ce.Enabled = true;
                cf.Enabled = true;
                cg.Enabled = true;
                ch.Enabled = true;
                ci.Enabled = true;
                cj.Enabled = true;
                ck.Enabled = true;
                cl.Enabled = true;
                //plansza b
                a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if g1
                if (g2.Text == "X" | g2.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                //plansza b
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                e.Enabled = true;
                f.Enabled = true;
                g.Enabled = true;
                h.Enabled = true;
                i.Enabled = true;
                //plansza c
                j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } //koniec if g2
                if (g3.Text == "X" | g3.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                //plansza c
                j.Enabled = true;
                k.Enabled = true;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                p.Enabled = true;
                r.Enabled = true;
                s.Enabled = true;
                //plansza d
                t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if g3
                if (g4.Text == "X" | g4.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                //plansza d
                t.Enabled = true;
                u.Enabled = true;
                w.Enabled = true;
                y.Enabled = true;
                z.Enabled = true;
                aa.Enabled = true;
                ab.Enabled = true;
                ac.Enabled = true;
                ad.Enabled = true;
                //plansza e
                ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if g4
                if (g5.Text == "X" | g5.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                //plansza e
                ae.Enabled = true;
                af.Enabled = true;
                ag.Enabled = true;
                ah.Enabled = true;
                ai.Enabled = true;
                aj.Enabled = true;
                ak.Enabled = true;
                al.Enabled = true;
                am.Enabled = true;
                //plansza f
                an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if g5
                if (g6.Text == "X" | g6.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                //plansza f
                an.Enabled = true;
                ao.Enabled = true;
                ap.Enabled = true;
                ar.Enabled = true;
                ass.Enabled = true;
                at.Enabled = true;
                au.Enabled = true;
                aw.Enabled = true;
                ay.Enabled = true;
                //plansza g
                az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if g6
                  //pomijam klawisz g7(lewy dolny róg)
                if (g8.Text == "X" | g8.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                //plansza h
                bi.Enabled = true;
                bj.Enabled = true;
                bk.Enabled = true;
                bl.Enabled = true;
                bm.Enabled = true;
                bn.Enabled = true;
                bo.Enabled = true;
                bp.Enabled = true;
                br.Enabled = true;
                //plansza i
                bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if g8
                if (g9.Text == "X" | g9.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                //plansza i
                bs.Enabled = true;
                bt.Enabled = true;
                bu.Enabled = true;
                bw.Enabled = true;
                by.Enabled = true;
                bz.Enabled = true;
                ca.Enabled = true;
                cb.Enabled = true;
                cc.Enabled = true;
            } // koniec if g9

                //blokada związana z plansza h
                if (h1.Text == "X" | h1.Text == "O")
                {
                //plansa a
                cd.Enabled = true;
                ce.Enabled = true;
                cf.Enabled = true;
                cg.Enabled = true;
                ch.Enabled = true;
                ci.Enabled = true;
                cj.Enabled = true;
                ck.Enabled = true;
                cl.Enabled = true;
                //plansza b
                a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if h1
                if (h2.Text == "X" | h2.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                //plansza b
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                e.Enabled = true;
                f.Enabled = true;
                g.Enabled = true;
                h.Enabled = true;
                i.Enabled = true;
                //plansza c
                j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } //koniec if h2
                if (h3.Text == "X" | h3.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                //plansza c
                j.Enabled = true;
                k.Enabled = true;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                p.Enabled = true;
                r.Enabled = true;
                s.Enabled = true;
                //plansza d
                t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if h3
                if (h4.Text == "X" | h4.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                //plansza d
                t.Enabled = true;
                u.Enabled = true;
                w.Enabled = true;
                y.Enabled = true;
                z.Enabled = true;
                aa.Enabled = true;
                ab.Enabled = true;
                ac.Enabled = true;
                ad.Enabled = true;
                //plansza e
                ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if h4
                if (h5.Text == "X" | h5.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                //plansza e
                ae.Enabled = true;
                af.Enabled = true;
                ag.Enabled = true;
                ah.Enabled = true;
                ai.Enabled = true;
                aj.Enabled = true;
                ak.Enabled = true;
                al.Enabled = true;
                am.Enabled = true;
                //plansza f
                an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if h5
                if (h6.Text == "X" | h6.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                //plansza f
                an.Enabled = true;
                ao.Enabled = true;
                ap.Enabled = true;
                ar.Enabled = true;
                ass.Enabled = true;
                at.Enabled = true;
                au.Enabled = true;
                aw.Enabled = true;
                ay.Enabled = true;
                //plansza g
                az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if h6
                if (h7.Text == "X" | h7.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                //plansza g
                az.Enabled = true;
                ba.Enabled = true;
                bb.Enabled = true;
                bc.Enabled = true;
                bd.Enabled = true;
                be.Enabled = true;
                bf.Enabled = true;
                bg.Enabled = true;
                bh.Enabled = true;
                //plansza h
                bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if h7
                  // pomijam klawisz h8 (dół)
                if (h9.Text == "X" | h9.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                //plansza i
                bs.Enabled = true;
                bt.Enabled = true;
                bu.Enabled = true;
                bw.Enabled = true;
                by.Enabled = true;
                bz.Enabled = true;
                ca.Enabled = true;
                cb.Enabled = true;
                cc.Enabled = true;
            } // koniec if h9

                //blokada planszy i
                if (i1.Text == "X" | i1.Text == "O")
                {
                //plansa a
                cd.Enabled = true;
                ce.Enabled = true;
                cf.Enabled = true;
                cg.Enabled = true;
                ch.Enabled = true;
                ci.Enabled = true;
                cj.Enabled = true;
                ck.Enabled = true;
                cl.Enabled = true;
                //plansza b
                a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if i1
                if (i2.Text == "X" | i2.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                //plansza b
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                e.Enabled = true;
                f.Enabled = true;
                g.Enabled = true;
                h.Enabled = true;
                i.Enabled = true;
                //plansza c
                j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } //koniec if i2
                if (i3.Text == "X" | i3.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                //plansza c
                j.Enabled = true;
                k.Enabled = true;
                l.Enabled = true;
                m.Enabled = true;
                n.Enabled = true;
                o.Enabled = true;
                p.Enabled = true;
                r.Enabled = true;
                s.Enabled = true;
                //plansza d
                t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if i3
                if (i4.Text == "X" | i4.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                //plansza d
                t.Enabled = true;
                u.Enabled = true;
                w.Enabled = true;
                y.Enabled = true;
                z.Enabled = true;
                aa.Enabled = true;
                ab.Enabled = true;
                ac.Enabled = true;
                ad.Enabled = true;
                //plansza e
                ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if i4
                if (i5.Text == "X" | i5.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                //plansza e
                ae.Enabled = true;
                af.Enabled = true;
                ag.Enabled = true;
                ah.Enabled = true;
                ai.Enabled = true;
                aj.Enabled = true;
                ak.Enabled = true;
                al.Enabled = true;
                am.Enabled = true;
                //plansza f
                an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if i5
                if (i6.Text == "X" | i6.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                //plansza f
                an.Enabled = true;
                ao.Enabled = true;
                ap.Enabled = true;
                ar.Enabled = true;
                ass.Enabled = true;
                at.Enabled = true;
                au.Enabled = true;
                aw.Enabled = true;
                ay.Enabled = true;
                //plansza g
                az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                    //plansza h
                    bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if i6
                if (i7.Text == "X" | i7.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                //plansza g
                az.Enabled = true;
                ba.Enabled = true;
                bb.Enabled = true;
                bc.Enabled = true;
                bd.Enabled = true;
                be.Enabled = true;
                bf.Enabled = true;
                bg.Enabled = true;
                bh.Enabled = true;
                //plansza h
                bi.Enabled = false;
                    bj.Enabled = false;
                    bk.Enabled = false;
                    bl.Enabled = false;
                    bm.Enabled = false;
                    bn.Enabled = false;
                    bo.Enabled = false;
                    bp.Enabled = false;
                    br.Enabled = false;
                    //plansza i
                    bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if i7
                if (i8.Text == "X" | i8.Text == "O")
                {
                    //plansa a
                    cd.Enabled = false;
                    ce.Enabled = false;
                    cf.Enabled = false;
                    cg.Enabled = false;
                    ch.Enabled = false;
                    ci.Enabled = false;
                    cj.Enabled = false;
                    ck.Enabled = false;
                    cl.Enabled = false;
                    //plansza b
                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    e.Enabled = false;
                    f.Enabled = false;
                    g.Enabled = false;
                    h.Enabled = false;
                    i.Enabled = false;
                    //plansza c
                    j.Enabled = false;
                    k.Enabled = false;
                    l.Enabled = false;
                    m.Enabled = false;
                    n.Enabled = false;
                    o.Enabled = false;
                    p.Enabled = false;
                    r.Enabled = false;
                    s.Enabled = false;
                    //plansza d
                    t.Enabled = false;
                    u.Enabled = false;
                    w.Enabled = false;
                    y.Enabled = false;
                    z.Enabled = false;
                    aa.Enabled = false;
                    ab.Enabled = false;
                    ac.Enabled = false;
                    ad.Enabled = false;
                    //plansza e
                    ae.Enabled = false;
                    af.Enabled = false;
                    ag.Enabled = false;
                    ah.Enabled = false;
                    ai.Enabled = false;
                    aj.Enabled = false;
                    ak.Enabled = false;
                    al.Enabled = false;
                    am.Enabled = false;
                    //plansza f
                    an.Enabled = false;
                    ao.Enabled = false;
                    ap.Enabled = false;
                    ar.Enabled = false;
                    ass.Enabled = false;
                    at.Enabled = false;
                    au.Enabled = false;
                    aw.Enabled = false;
                    ay.Enabled = false;
                    //plansza g
                    az.Enabled = false;
                    ba.Enabled = false;
                    bb.Enabled = false;
                    bc.Enabled = false;
                    bd.Enabled = false;
                    be.Enabled = false;
                    bf.Enabled = false;
                    bg.Enabled = false;
                    bh.Enabled = false;
                //plansza h
                bi.Enabled = true;
                bj.Enabled = true;
                bk.Enabled = true;
                bl.Enabled = true;
                bm.Enabled = true;
                bn.Enabled = true;
                bo.Enabled = true;
                bp.Enabled = true;
                br.Enabled = true;
                //plansza i
                bs.Enabled = false;
                    bt.Enabled = false;
                    bu.Enabled = false;
                    bw.Enabled = false;
                    by.Enabled = false;
                    bz.Enabled = false;
                    ca.Enabled = false;
                    cb.Enabled = false;
                    cc.Enabled = false;
                } // koniec if i8
                  //pomijam klawisz i9(prawy dolny róg)
            
            return null;
         }

        
    }


}

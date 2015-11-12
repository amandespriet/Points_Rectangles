using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{

    struct Point2D
    {
        public int x1;
        public int y1;

        public Point2D(int x, int y)
        {
            x1 = x;
            y1 = y;
        }
    }

    struct Rectangle2D
    {
        public int num;
        public Point2D supG;
        public Point2D infB;

        public Rectangle2D(int n, Point2D sg, Point2D ib)
        {
            num = n;
            supG = sg;
            infB = ib;
        }
        
        public int LargeurRectangle()
        {
            int largeur = Math.Abs(supG.y1 - infB.y1);
            return (largeur);
        }

        public int LongueurRectangle()
        {
            int longueur = Math.Abs(supG.x1 - infB.x1);
            return (longueur);
        }

        public int AireRectangle()
        {
            int aire = LargeurRectangle() * LongueurRectangle();
            return (aire);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //exemple d'attribution des coordonnées pour les points p et pbis
            Point2D p, pbis;
            p.x1 = 10;
            p.y1 = 20;
            pbis.x1 = 25;
            pbis.y1 = 12;
            

            Point2D P1 = new Point2D(1, 2);
            Point2D P2 = new Point2D(10, 25);
            Point2D P3 = new Point2D(15, -1);
            Point2D P4 = new Point2D(30, 20);

            Rectangle2D R1 = new Rectangle2D(1, P1, P3);
            Rectangle2D R3 = new Rectangle2D(3, P2, P4);

            
            Console.WriteLine("La largeur du rectangle numéro 1 est égale à : " + R1.LargeurRectangle());

            Console.WriteLine("L'aire du rectangle numéro 3 est égale à : " +R3.AireRectangle());

            Console.ReadKey();

        }
    }
}

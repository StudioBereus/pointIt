using System;
using System.Collections.Generic;
using System.Text;

namespace pointIt
{
    class Point
    {
        //Attributs
        public double positionX;
        public double positionY;

        //Constructeurs
        public Point(){
            positionX = 0;
            positionY = 0;
        }
        public Point(int AxeX, int AxeY){
            positionX = AxeX;
            positionY = AxeY;
        }
        public override string toString()
        {
             Console.WriteLine("Le point a pour coorodnnées en X :" + this.positionX + " et  en Y :" + this.positionY);
        }
        public void swap(Point point2){
            //X
            double temPosX = this.positionX;
            this.positionX = point2.positionX;
            point2.positionX = temPosX;

            //Y
            double temPosY = this.positionY;
            this.positionY = point2.positionY;
            point2.positionY = temPosY;
        }
        public void moveX(double distance) {
            positionX += distance;
            Console.WriteLine("Le point se trouve à présent aux coordonnées (" + positionX + ";" + positionY + ")");
        }
        public void moveY(double distance){
            positionY += distance;
            Console.WriteLine("Le point se trouve à présent aux coordonnées (" + positionX + ";" + positionY + ")");
        }
        public void moveAll(double distanceX, double distanceY){
            this.moveX(distanceX);
            this.moveY(distanceY);
            Console.WriteLine("Le point se trouve à présent aux coordonnées (" + positionX + ";" + positionY + ")");
        }
        public void symX(){
            this.positionY *= -1;
            Console.WriteLine("("+positionX + " ; " + positionY+")");
        }
        public void symY(){
            this.positionY *= -1;
        }
        public void symOr(){
            
        }
    }
}

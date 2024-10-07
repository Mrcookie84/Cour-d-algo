using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


namespace ConsoleApplication1
{
    public class Algo2
    {
        public void Exo2()
        {
            int N1 = 60;
            int N2 = 24;
            int N3 = 365;
            
            Console.WriteLine("votre nombre est en ? 1 = secondes 2 = minutes 3 = heures 4 = jours : ");
            int choix = int.Parse(Console.ReadLine());
            
            
            if (choix == 1) 
            {
                float m = 0f;
                float h = 0f;
                float j = 0f;
                float a = 0f;
                
              //demande un nombre en seconde
              Console.WriteLine("entre un nombre de secondes : ");
              float s = int.Parse(Console.ReadLine());
              
             //affiche le nombre de secondes convertie en minutes dans la console
              m = s / N1;
             //affiche le nombre de minutes convertie en heures dans la console
              h = m / N1;
              //affiche le nombre de heures convertie en jours dans la console
              j = h / N2;
             //affiche le nombre de jours convertie en année de 365 jours
             a = j / N3;
             
             Console.Write(s + "_" + "secondes" + " " + "=" + " ");
             Console.Write(m + "_" + "minutes" + " " + "=" + " ");
             Console.Write(h + "_" + "heures" + " " + "=" + " ");
             Console.Write(j + "_" + "jours" + " " + "=" + " ");
             Console.Write(a + "_" + "années" + " ");
            }

            if (choix == 2)
            {
                float s = 0f;
                float h = 0f;
                float j = 0f;
                float a = 0f;
                
                Console.WriteLine("entre un nombre de minutes : ");
                float m = int.Parse(Console.ReadLine());
                
                // M to S
                s = m * N1;
                // M to H
                h = m / N1;
                // H to J
                j = h / N2;
                // J to A
                a = j / N3;
                
                
                Console.Write(s + "_" + "secondes" + " " + "=" + " ");
                Console.Write(m + "_" + "minutes" + " " + "=" + " ");
                Console.Write(h + "_" + "heures" + " " + "=" + " ");
                Console.Write(j + "_" + "jours" + " " + "=" + " ");
                Console.Write(a + "_" + "années" + " ");
            }

            if (choix == 3)
            {
                float s = 0f;
                float m = 0f;
                float j = 0f;
                float a = 0f;
                
                Console.WriteLine("entre un nombre de heures : ");
                float h = int.Parse(Console.ReadLine());
                
                // H to M
                m = h * N1;
                // M to S
                s = m * N1;
                // H to J
                j = h / N2;
                // J to A
                a = j / N3;
                
                Console.Write(s + "_" + "secondes" + " " + "=" + " ");
                Console.Write(m + "_" + "minutes" + " " + "=" + " ");
                Console.Write(h + "_" + "heures" + " " + "=" + " ");
                Console.Write(j + "_" + "jours" + " " + "=" + " ");
                Console.Write(a + "_" + "années" + " ");
            }

            if (choix == 4)
            {
                float s = 0f;
                float m = 0f;
                float h = 0f;
                float a = 0f;
                
                Console.WriteLine("entre un nombre de jours : ");
                float j = int.Parse(Console.ReadLine());
                
                // J to H
                h = j * N2;
                // H to M
                m = h * N1;
                // J to S
                s = m * N1;
                // J to A
                a = j / N3;
                
                Console.Write(s + "_" + "secondes" + " " + "=" + " ");
                Console.Write(m + "_" + "minutes" + " " + "=" + " ");
                Console.Write(h + "_" + "heures" + " " + "=" + " ");
                Console.Write(j + "_" + "jours" + " " + "=" + " ");
                Console.Write(a + "_" + "années" + " ");
            }
            
        }
        
    }
}
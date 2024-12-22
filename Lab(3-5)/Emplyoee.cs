using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_5_
{
    //Task2

    public class Ishci
    {
        public string IstifadechiAdi { get; set; }  // User Name
        public string IshciAdi { get; set; }        // Employee Name
        public string Shobe { get; set; }           // Branch Name
        public double Maash { get; set; }           // Salary
        public int Tecrube { get; set; }            // Experience in years

        public Ishci(string istifadechiAdi, string ishciAdi, string shobe, double maash, int tecrube)
        {
            IstifadechiAdi = istifadechiAdi;
            IshciAdi = ishciAdi;
            Shobe = shobe;
            Maash = maash;
            Tecrube = tecrube;
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    public class SuperHero
    {
        // superhero class, here we can create already existing super heroes or make our own

        private string _secretIdentity; // the superhero's real name
        private string _superCostume; // how the hero hides their identity
        private string _archNemsis; // who does the hero fight the most, or have the hardest battles against? i.e, batman and joker
        private string _internalProblems; //what does the hero go through outside of superhero duties? 
        private string[] _superPowers; //the hero's hopefully unique power. alternatively could use an array, in case of multiple powers, or for specific powers that could temporarily steal or anything of the sort
        private string[] _reorccuringEnemies; // all the reorccuring enemies that the hero fights, usually important but lesser enemies compared to the arch nemesis




        public string secretIdentity
        {
            get { return _secretIdentity; }
            set { _secretIdentity = value; }
        }

        public string[] superPowers
        {
            get { return _superPowers; }
            set { _superPowers = value; }
        }
        public string superCostume
        {
            get { return _superCostume; }
            set { _superCostume = value; }
        }
        public string archNemesis
        {
            get { return _archNemsis; }
            set { _archNemsis = value; }
        }
        public string[] reorccuringEnemies
        {
            get { return _reorccuringEnemies; }
            set { _reorccuringEnemies = value; }
        }

        public string internalProblems
        {
            get { return _internalProblems; }
            set { _internalProblems = value; }
        }


        public void UseSuperPower()
        {
            // use superhero's superpower
        }
        public void ChangeToCostume()
        {
            //change to costume
        }
        public void Flying()
        {
            // optional ability to fly, incase superhero has that ability, however this is not the same as UseSuperPower
        }

    }

}
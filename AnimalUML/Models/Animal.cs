using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalUML.Models
{
    public class Animal
    {
        private string animalName;
        private int population;
        private int age;
        private AnimalType animalType;
        private ClassifiedAs classifiedAs;
        private FoodType foodType;
        private AnimalKingdom animalkingdom;

        public string AnimalName { get => animalName; set => animalName = value; }
        public int Population { get => population; set => population = value; }
        public int Age { get => age; set => age = value; }
        public ClassifiedAs ClassifiedAs { get => classifiedAs; set => classifiedAs = value; }
        public FoodType FoodType { get => foodType; set => foodType = value; }
        public AnimalKingdom Animalkingdom { get => animalkingdom; set => animalkingdom = value; }
    }
}
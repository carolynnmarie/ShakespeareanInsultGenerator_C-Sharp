using System;

namespace C_Sharp_Shakespeare{
    public class RandomInsultGenerator{
        Insults insults {get;set;}
        Random random {get;set;}

        public RandomInsultGenerator(){
            this.insults = new Insults();
            this.random = new Random();
        }

        public string createRandomInsult(){
            int one = random.Next(0,insults.partOne.Length);
            int two = random.Next(0, insults.partTwo.Length);
            int three = random.Next(0, insults.partThree.Length);
            return "Thou " + insults.partOne[one] + " " + insults.partTwo[two] + " " + insults.partThree[three];
        }

        public string getClassicInsult(){
            int one = random.Next(0,insults.classic.Length);
            return insults.classic[one];
        }

        public string pickRandomOrClassic(string input){
            string output = "";
            if(input.Equals("classic")) output = getClassicInsult();
            else if(input.Equals("random")) output = createRandomInsult();
            return output;
        }

    }
}
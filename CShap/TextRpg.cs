

namespace MyApp
{
    internal class TextRpg
    {
        enum JobType {
            None = 0,
            Warrior = 1,
            Archer = 2,
            Wizard = 3
        }

        struct Player{
            public JobType job;
            public int maxHp;
            public int attack;
        }
        static JobType ChooseJob(){
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] : 전사");
            Console.WriteLine("[2] : 궁수");
            Console.WriteLine("[3] : 마법사");
            string input = Console.ReadLine();
            JobType job = JobType.None;
            switch (input){
                case "1":
                    job = JobType.Warrior;
                    break;
                case "2":
                    job = JobType.Archer;
                    break;
                case "3":
                    job = JobType.Wizard;
                    break;
            }
            return job;
        }

        static void SettingValue(JobType jobType, out int maxHp, out int attack){
            switch(jobType){
                case JobType.Warrior:
                    maxHp = 100;
                    attack = 10;
                    break;
                case JobType.Archer:
                    maxHp = 80;
                    attack = 12;
                    break;
                case JobType.Wizard:
                    maxHp = 55;
                    attack = 15;
                    break;
                default:
                    maxHp = 0;
                    attack = 0;
                    break;
            }
        }
        static void Main(String[] args){
            Player player;
            player.job = JobType.None;
            // 직업고르기
            while(player.job == JobType.None){
                player.job = ChooseJob();
            }
            
            SettingValue(player.job, out player.maxHp, out player.attack);
            Console.WriteLine($"job : {player.job}, maxHp : {player.maxHp}, attack : {player.attack}");
        }
    }
}


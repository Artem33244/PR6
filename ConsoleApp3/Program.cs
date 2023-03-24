using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        string[] vitals = { "Виталя" };
        string[] phantoms = { "Фантом" };

        string[] actions = {
            "подбежал к ",
            "быстро шел за у",
            "нашел в углу такое... ",
            "спрятался от",
            "выкрикнул в лицо ",
            "выбежал из-за угла и набросился на ",
            "схватил за руку ",
            "закинул на плечи ",
            "зашел в комнату и увидел "
        };

        string[] reactions = {
            "испугался и замер",
            "закричал и убежал",
            "расхохотался и танцевал",
            "рассердился и начал драку",
            "обиделся и ушел",
            "насмехался и пошел дальше",
            "обернулся и удивился",
            "заплакал и убежал",
            "воскликнул \"Вау!\" и поднял в воздух",
            "задумался и спросил: \"Что это было?\"",
            "покачал головой и сказал \"Ну ты и шутник\""
        };

        for (int i = 0; i < 10; i++)
        {
            string vital = vitals[rnd.Next(vitals.Length)];
            string phantom = phantoms[rnd.Next(phantoms.Length)];
            string action = actions[rnd.Next(actions.Length)];
            string reaction = reactions[rnd.Next(reactions.Length)];

            Console.WriteLine($"{vital} {action} {phantom}, а тот {reaction}.");
        }

        Console.ReadKey();
    }
}
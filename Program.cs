// See https://aka.ms/new-console-template for more information

MinimumSpeedArriveTime.MinimumSpeedArriveTime minimumSpeedArriveTime = new();
Console.WriteLine(minimumSpeedArriveTime.MinSpeedOnTime(new int[] { 1, 3, 2 }, 6));
Console.WriteLine(minimumSpeedArriveTime.MinSpeedOnTime(new int[] { 1, 3, 2 }, 2.7));
Console.WriteLine(minimumSpeedArriveTime.MinSpeedOnTime(new int[] { 1, 3, 2 }, 1.9));
Console.WriteLine(minimumSpeedArriveTime.MinSpeedOnTime(new int[] { 1, 1, 100000 }, 2.01));

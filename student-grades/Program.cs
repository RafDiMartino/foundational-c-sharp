// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

decimal sophiaGrades = ((decimal)sophia1 + (decimal)sophia2 + (decimal)sophia3 + (decimal)sophia4 + (decimal)sophia5) / (decimal)currentAssignments;
decimal nicolasGrades = ((decimal)nicolas1 + (decimal)nicolas2 + (decimal)nicolas3 + (decimal)nicolas4 + (decimal)nicolas5) / (decimal)currentAssignments;
decimal zahirahGrades = ((decimal)zahirah1 + (decimal)zahirah2 + (decimal)zahirah3 + (decimal)zahirah4 + (decimal)zahirah5) / (decimal)currentAssignments;
decimal jeongGrades = ((decimal)jeong1 + (decimal)jeong2 + (decimal)jeong3 + (decimal)jeong4 + (decimal)jeong5) / (decimal)currentAssignments;

Console.WriteLine($"Student     Grade\n");
Console.WriteLine($"Sophia      {sophiaGrades}  A");
Console.WriteLine($"Nicolas     {nicolasGrades}  B");
Console.WriteLine($"Zahirah     {zahirahGrades}  B");
Console.WriteLine($"Jeong       {jeongGrades}  A");
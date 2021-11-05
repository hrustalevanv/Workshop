ouble OneFriends = 1;
double SecondFriends = 2;
double DogSpeed = 5;
double distance = 10000;
double distance0 = 5;
int friend = 2;
int count = 0;
double time = 0;

while(distance0 < distance)
{
    if (friend == 2)
    {
        time = distance/(OneFriends + DogSpeed);
        friend = 1;
    }
else
    {
        time = distance/(SecondFriends + DogSpeed);
        friend = 2;
    }
    distance = distance - (OneFriends + SecondFriends) * time;
    Console.WriteLine($"Расстояние {count ++} раз");
    Console.WriteLine($"дистанция = {distance:f2}");
    count ++;
}

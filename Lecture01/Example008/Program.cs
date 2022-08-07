int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int amount = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        amount = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        amount = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * amount;
    count++;
}

Console.WriteLine(count);
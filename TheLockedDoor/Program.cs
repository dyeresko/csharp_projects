

Door doorInstance = new Door(55);
int userPasscode = Door.AskForPassword();

while (true)
{
    doorInstance.ManipulateTheLock(userPasscode);
}


class Door
{
    public DoorState doorState { get; private set; } = DoorState.locked;
    public int passcode { get; private set; }



    public Door(int passcode)
    {
        this.passcode = passcode;
    }

    public void ManipulateTheLock(int userPasscode)
    {


        if (userPasscode == this.passcode)
        {
            if (doorState == DoorState.locked)
                doorState = DoorState.closed;

            switch (doorState)
            {
                case DoorState.closed:
                    doorState = AskForAction() switch
                    {
                        "open" => DoorState.open,
                        "lock" => DoorState.locked,
                        _ => DoorState.closed

                    };
                    break;
                case DoorState.open:
                    doorState = AskForAction() switch
                    {
                        "close" => DoorState.closed,
                        _ => DoorState.open
                    };
                    break;
            }
            if (doorState == DoorState.locked)
            {
                userPasscode = AskForPassword();
                ManipulateTheLock(userPasscode);
            }
        }
        else
        {
            userPasscode = AskForPassword();
            ManipulateTheLock(userPasscode);
        }
    }



    private void ChangeThePassword()
    {
        System.Console.WriteLine("Enter current password: ");
        int Passcode = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine(Passcode);
        if (Passcode == passcode)
        {
            System.Console.WriteLine("Enter new password: ");
            passcode = Convert.ToInt32(System.Console.Read());
        }
        else
        {
            ManipulateTheLock(Passcode);
        }
    }
    public static int AskForPassword()
    {
        System.Console.WriteLine($"The door is locked. Enter the passcode to unlock");
        return Convert.ToInt32(System.Console.ReadLine());
    }

    private string AskForAction()
    {
        System.Console.WriteLine($"The door is {doorState}. What do you want to do? ");
        string answer = System.Console.ReadLine();

        if (answer == "change the password")
        {
            ChangeThePassword();
            return AskForAction();
        }
        else
        {
            return answer;
        }
    }




}

enum DoorState
{
    closed,
    locked,
    open
}


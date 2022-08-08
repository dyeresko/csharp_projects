ChestState currentState = ChestState.Locked;
ChestStateDesc currentStateDesc = ChestStateDesc.locked;

while (true)
{
    (currentStateDesc, currentState) = ManipulateTheChest(currentState, currentStateDesc);
}



(ChestStateDesc, ChestState) ManipulateTheChest(ChestState chestState, ChestStateDesc chestStateDesc)
{

    System.Console.WriteLine($"The chest is {chestStateDesc}. What do you want to do? ");
    string command = System.Console.ReadLine();



    switch (chestState)
    {
        case ChestState.Locked:

            (chestStateDesc, chestState) = command switch
            {
                "unlock" => (ChestStateDesc.unlocked, ChestState.Closed),
                _ => (ChestStateDesc.locked, ChestState.Locked)
            };
            return (chestStateDesc, chestState);
        case ChestState.Closed:
            (chestStateDesc, chestState) = command switch
            {
                "open" => (ChestStateDesc.open, ChestState.Open),
                "lock" => (ChestStateDesc.locked, ChestState.Locked),
                _ => (ChestStateDesc.unlocked, ChestState.Closed)
            };
            return (chestStateDesc, chestState);
        case ChestState.Open:
            (chestStateDesc, chestState) = command switch
            {
                "close" => (ChestStateDesc.unlocked, ChestState.Closed),
                _ => (ChestStateDesc.open, ChestState.Open)
            };
            return (chestStateDesc, chestState);
        default:
            return (chestStateDesc, chestState);
    }
}

enum ChestState
{
    Locked,
    Open,
    Closed,

}

enum ChestStateDesc
{
    locked,
    unlocked,
    open
}


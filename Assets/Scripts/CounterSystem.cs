using UnityEngine;

public class CounterSystem
{
    public static bool IsCounter(MaskType player, MaskType enemy)
    {
        return (player == MaskType.Red && enemy == MaskType.Green) ||
               (player == MaskType.Green && enemy == MaskType.Blue) ||
               (player == MaskType.Blue && enemy == MaskType.Red);
    }
}

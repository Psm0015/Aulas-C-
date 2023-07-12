using System;

class Aula19
{
    static void Main(){

        int[] nums = new int[10];

        for (int num = 0; num < 10; num++)
        {  
            Console.WriteLine("{0} - Pedro Mota",num+1);
        }
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

        for (int i = 0; i < nums.Length; i++)
        {  
            nums[i] = 0;
            Console.WriteLine(nums[i]);
        }
        // for (int i = 0; i < 10; i++)
        // {  
        //     nums[i] = 0;
        //     Console.WriteLine(nums[i]);
        // }
    }
}
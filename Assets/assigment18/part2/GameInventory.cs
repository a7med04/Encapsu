using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18.part2
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {

            Inventory potions = new Inventory();
            potions.AddItem("Healing  Potion");
            potions.AddItem("Strength Potion");

            Inventory elixirs = new Inventory();
            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");

            OverloadOperator potion1 = new OverloadOperator("Healing Potion");
            OverloadOperator potion2 = new OverloadOperator("Strength Potion");
            OverloadOperator elixir1 = new OverloadOperator("Elixir");
            OverloadOperator elixir2 = new OverloadOperator("Dark Elixir");

            Debug.Log(potion1 + potion2);
            Debug.Log(elixir1 + elixir2);

            potions.ShowItems();
            elixirs.ShowItems();
            
        }
    }
}
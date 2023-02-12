using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class JSON_factory : MonoBehaviour
{
    void Start()
    {
        UnitGeneralFactory unitGeneralFactory = new UnitGeneralFactory();
        List<IUnit> unitList = new List<IUnit>();
        string JSON_str = File.ReadAllText(Directory.GetCurrentDirectory() + "\\" + "JSON_factory.json");
        string lastType = "";
        for(int i = 0; i < JSON_str.Length; i++)
        {
            if (JSON_str[i] == ':' && JSON_str.Substring(i-5, 4) == "type")
            {
                if (JSON_str.Substring(i+3, 3) == "mag")
                {
                    lastType = "mag";
                }
                else if(JSON_str.Substring(i+3, 8) == "infantry")
                {
                    lastType = "infantry";
                }

            }
            else if (JSON_str[i] == ':' && JSON_str.Substring(i-7, 6) == "health")
            {
                string health_str = "";

                for(int j = 0; j < 10; j++)
                {
                    if (JSON_str[i+3+j] != '\"')
                    {
                        health_str += JSON_str[i+3+j];
                    }
                    else
                    {
                        break;
                    }
                }

                IUnit unit = unitGeneralFactory.GetUnit(lastType, int.Parse(health_str));
                unitList.Add(unit);
            }
        }

        Debug.Log(unitList[0].Type);
        Debug.Log(unitList[0].Health + "\n");

        Debug.Log(unitList[1].Type);
        Debug.Log(unitList[1].Health + "\n");

        Debug.Log(unitList[2].Type);
        Debug.Log(unitList[2].Health + "\n");
    }
}

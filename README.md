# Контрольная работа


## Задание итоговой работы
![Picture](Task.png)


## Блок-схема алгоритма формирования массива 
![Picture](Diagram.png)



## Код метода алгоритма
---
    string [] CreateTruncatedArray(string [] mas)
    {
        int n = mas.Length;
        string [] NewArr = new string[n];
        int k = 0;
        for(int i=0; i < n; i++)
            if(mas[i].Length <=3)
                NewArr[k++] = mas[i];
        System.Array.Resize(ref NewArr, k);
        return NewArr;        
    }
---






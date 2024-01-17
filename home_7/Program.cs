//Вычислить значение формулы A * B/ C + D, где a,b,c,d - некоторые целые числаю Решение оформить в виде функции.
double CalculateFormula(int a, int b, int c, int d) //задаем тип возвращаемых данных double ( для сохранения дробной части выражения)
                                                    // | имя функции | параметры целые числа int
{
    int numenate = a * b;                           // задаем числитель
    int numenate2 = c + d;                          // задаем знаменатель
    double result = numenate/numenate2;             // задаем переменную result для вычисления деления 
    return result;                                  // возвращаем результат
}

double result = CalculateFormula(8,8,8,2);          // вызов функции с заданными значениями
Console.WriteLine(result);                          // вывод результата на консоль с импользованием переменной result

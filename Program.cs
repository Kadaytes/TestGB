// метод сортировки Sorting  производит сортировку входного массива 
// строк text путем записи в новый массив строк array 
// последовательно элементов (строк) входного массива длиной менее 
// установленного n количества символов.  
void Sorting (string[] text, int m, string[] array, int j, int pr)
{
    if(pr==1) Console.Write( " [ ");
for (int i = 0; i < text.Length; i++)
{
   if(text[i].Length < m+1) 
   {
    array[j] = text[i];
    if(pr == 1 && j != 0) Console.Write ($", '{array [j]}' ");
    if(pr == 1 && j == 0) Console.Write ($" '{array [j]}' ");
    j++;
   }
}; if(pr==1) Console.Write( "] \n ");
};
// формирование входных данных
string[] text = new string[] {"hello", "2", "world",":-)", "-2", "Kazan", "202209"};
int m = 3;
string[] array = new string[text.Length];
int j = 0;
int pr = 1;
Sorting (text, m, array, j, pr);

string FindIntersection(string[] strArr) {
    // Split Arrays
    string finded = string.Empty;
    string[] array = strArr[0].Split(",");
    string[] searching = strArr[1].Split(",");

    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < searching.Length; j++)
            if (array[i] == searching[j]) {
                finded += array[i] + (i == searching.Length - 1 ? "" : ",");
            }

    return finded;
}


// Array
string[] array = new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
string[] array2 = new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" };

Console.WriteLine("----------");
Console.WriteLine(FindIntersection(array));
Console.WriteLine("----------");
Console.WriteLine(FindIntersection(array2));
Console.WriteLine("----------");

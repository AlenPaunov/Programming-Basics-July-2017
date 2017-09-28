using System;

class Hospital
{
    static void Main(string[] args)
    {
        var period = int.Parse(Console.ReadLine());
        var doctors = 7;
        var treatedPatients = 0;
        var untreatedPatients = 0;

        for (int i = 1; i <= period; i++)
        {
            var patients = int.Parse(Console.ReadLine());

            if (i % 3 == 0 && treatedPatients < untreatedPatients)
            {
                doctors++;
            }

            if (patients > doctors)
            {
                untreatedPatients += patients - doctors;
                treatedPatients += doctors;
                
            }
            else
            {
                treatedPatients += patients;
            }
        }
        Console.WriteLine($"Treated patients: {treatedPatients}.");
        Console.WriteLine($"Untreated patients: {untreatedPatients}.");
    }
}

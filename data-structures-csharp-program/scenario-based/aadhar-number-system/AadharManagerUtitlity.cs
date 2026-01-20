using System;

namespace BridgeLabzCopy.dsa_csharp_practice.scenario_based.SortAdhar
{
    internal class AadharManagerUtitlity : IAadharManager
    {
        private int _capacity;
        private Aadhar[] _adhars;
        private int _currIdx;

        public AadharManagerUtitlity(int size)
        {
            _capacity = size;
            _adhars = new Aadhar[size];
            _currIdx = 0;
        }

        // ADD AADHAR
        public void AddAadhar()
        {
            if (_currIdx >= _capacity)
            {
                Console.WriteLine("Adhar storage is full!");
                return;
            }

            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter the 12-digit Aadhaar number:");
            string adharNumber = Console.ReadLine();

            if (!AadharNumberValidation(adharNumber))
            {
                Console.WriteLine("Invalid Aadhaar number!");
                return;
            }

            Aadhar newAdhar = new Aadhar(name, address, adharNumber);
            _adhars[_currIdx++] = newAdhar;

            ArrangeAadhar();

            Console.WriteLine("\nNew Aadhaar added successfully:\n");
            Console.WriteLine(newAdhar);
        }

        //DISPLAY AADHAR
        public void DisplayAadhar()
        {
            if (_currIdx == 0)
            {
                Console.WriteLine("No Aadhaar records found.");
                return;
            }

            Console.WriteLine("\nAll Aadhaar Details:\n");

            for (int i = 0; i < _currIdx; i++)
            {
                Aadhar a = _adhars[i];
                Console.WriteLine(
                    $"Name: {a.GetName()}\t" +
                    $"Address: {a.GetAddress()}\t" +
                    $"Aadhaar: {a.GetAdharNumber()}"
                );
            }
        }

        // VALIDATION 
        public bool AadharNumberValidation(string adharNumber)
        {
            if (adharNumber == null || adharNumber.Length != 12)
                return false;

            for (int i = 0; i < adharNumber.Length; i++)
            {
                if (adharNumber[i] < '0' || adharNumber[i] > '9')
                    return false;
            }

            return true;
        }

        // ADIX SORT
        private void ArrangeAadhar()
        {
            int exp = 1;

            // Aadhaar has exactly 12 digits
            for (int i = 0; i < 12; i++)
            {
                CountingSort(exp);
                exp *= 10;
            }
        }

        private void CountingSort(int exp)
        {
            Aadhar[] output = new Aadhar[_currIdx];
            int[] count = new int[10];

            // Count digit frequency
            for (int i = 0; i < _currIdx; i++)
            {
                long number = Convert.ToInt64(_adhars[i].GetAdharNumber());
                long digit = (number / exp) % 10;
                count[digit]++;
            }

            // Prefix sum
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Build output (right to left -> stable sort)
            for (int i = _currIdx - 1; i >= 0; i--)
            {
                long number = Convert.ToInt64(_adhars[i].GetAdharNumber());
                long digit = (number / exp) % 10;

                output[count[digit] - 1] = _adhars[i];
                count[digit]--; 
            }

            // Copy back
            for (int i = 0; i < _currIdx; i++)
            {
                _adhars[i] = output[i];
            }
        }

        // search aadhar
        public void SearchAadhar()
        {
            Console.WriteLine("Enter the aadhar number : ");
            string aadharNumber = Console.ReadLine();

            Aadhar aadhar = BinarySearch(aadharNumber);
            if(aadhar == null)
            {
                Console.WriteLine("Aadhar is not found!");
            }
            else
            {
                Console.WriteLine(aadhar);
            }
        }
        private Aadhar BinarySearch(string aadharNumber)
        {
            int si = 0;
            int ei = _currIdx - 1;
            while(si <= ei)
            {
                int mid = (si + ei) / 2;

                string currentAadharNumber = _adhars[mid].GetAdharNumber();
                int cmp = string.Compare(aadharNumber, currentAadharNumber);

                if(cmp == 0)
                {
                    return _adhars[mid];
                }
                else if(cmp < 0)
                {
                    ei = mid - 1;
                }
                else
                {
                    si = mid + 1;
                }
            }

            return null;
        }
    }
}

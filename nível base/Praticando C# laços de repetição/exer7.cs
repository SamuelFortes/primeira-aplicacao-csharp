for (int i = 0; i < 21; i++)
        {
            string numeroStr = i.ToString();
            int resultado = 0;
            foreach (var numero in numeroStr)
            {
                string numCharToString = numero.ToString();
               resultado += int.Parse(numCharToString);
            }

            if(resultado % 3 == 0)
            {
                continue;
            }

            Console.WriteLine(i);
        }
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.interfacee
{
    internal class Interfacee
    {
        public void showInfo()
        {
            Console.WriteLine("\t \t \t \t \t М. В. Лянко, группа 423, СПбГТИ \n \t \t \t \t \tКонтрольная работа #1, вариант 10 \n");
        }

        public void showMenu() 
        {
            Console.WriteLine("Меню: \n[1] Запуск программы \n[2] Cохранить в файл \n[3] Запуск тестов \n[4] Выход");       
        }

        public void showInputTypeChoice()
        {
            Console.WriteLine("[1] Пользовательский ввод \n[2] Загрузить из файла");
            Console.Write("> ");
        }

        public void showChoice()
        {
            Console.WriteLine("[1] Да \n [2] Нет");
        }
    }
}
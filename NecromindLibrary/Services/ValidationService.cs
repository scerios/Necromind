﻿using NecromindLibrary.Models;
using System;
using System.Collections.Generic;

namespace NecromindLibrary.Services
{
    public static class ValidationService
    {
        /// <summary>
        /// Checks in a list of HeroModels if the given name as string is equal to any of the heroes's name inside the list.
        /// </summary>
        /// <param name="heroes">A list of HeroModels</param>
        /// <param name="heroName">The name as string to find.</param>
        /// <returns>True if given name is found. False otherwise.</returns>
        public static bool IsHeroNameAlreadyRegistered(List<HeroModel> heroes, string heroName) =>
            heroes.Find(h => h.Name == heroName) != null;

        /// <summary>
        /// Checks if given name's length is between 3 and 16 characters, also if first character is a letter.
        /// </summary>
        /// <param name="name">The name as a string.</param>
        /// <returns>True if given name is valid. False otherwise.</returns>
        public static bool IsValidName(string name) =>
            name.Length > 2 && name.Length < 17 && char.IsLetter(name[0]);

        public static bool IsGreaterThanOrEqualToZero(string input) =>
            IsInputValidNumber(input) && Int32.Parse(input) >= 0;

        public static bool IsGreaterThanZero(string input) =>
            IsInputValidNumber(input) && Int32.Parse(input) > 0;

        public static bool IsFirstIsGreaterThanSecond(string first, string second) =>
            (IsInputValidNumber(first) && IsInputValidNumber(second)) && Int32.Parse(first) > Int32.Parse(second);

        private static bool IsInputValidNumber(string input) =>
            Int32.TryParse(input, out _);
    }
}
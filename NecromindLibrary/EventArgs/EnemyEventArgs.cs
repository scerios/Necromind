using NecromindLibrary.Models;
using System;

namespace NecromindLibrary.EventArgs
{
    public class EnemyEventArgs : System.EventArgs
    {
        public EnemyModel Enemy { get; private set; }

        public EnemyEventArgs(EnemyModel enemy)
        {
            Enemy = enemy;
        }
    }
}
using System;

namespace MailSchools
{
    [Flags]
    public enum SchoolType
    {
        Gymnasie = 1,
        Grundskola = 2,
        Sarskola = 4
    }
    [Flags]
    public enum Topic
    {
        Techical = 1,
        Omsorg = 2,
        Fordon = 4
    }
}

using System;
using System.Runtime.Serialization;

[Serializable]
internal class MissionNotAchievedException : Exception
{
    public MissionNotAchievedException()
    {
    }

    public MissionNotAchievedException(string message) : base(message)
    {
    }

    public MissionNotAchievedException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected MissionNotAchievedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
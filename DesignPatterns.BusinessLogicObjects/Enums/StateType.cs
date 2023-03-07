using System.ComponentModel;

namespace DesignPatterns.BusinessLogicObjects.Enums;

public enum StateType: byte
{
    [Description("")]
    None = 0,

    [Description("Новая")]
    New = 1,

    [Description("В работе")]
    Work = 2,

    [Description("Решена")]
    Resolved = 3,

    [Description("Обратная связь")]
    Feedback = 4,

    [Description("Закрыта")]
    Close = 5
}
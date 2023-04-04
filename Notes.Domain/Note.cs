using System;

// Получение, создание редактирования заметок, валидации запросов 

///GUID — статистически уникальный 128-битный идентификатор. Его главная особенность — уникальность,
/// которая позволяет создавать расширяемые сервисы и приложения без опасения конфликтов, вызванных совпадением ///
namespace Notes.Domain
{
    public class Note
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate{ get; set; }
        public DateTime?  EditDate { get; set; }
    }
}

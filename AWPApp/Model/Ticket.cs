//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AWPApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public int TicketPatientId { get; set; }
        public System.DateTime TicketDate { get; set; }
        public int TicketDoctorId { get; set; }
        public int TicketRoomId { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Room Room { get; set; }
        public virtual Worker Worker { get; set; }
    }
}

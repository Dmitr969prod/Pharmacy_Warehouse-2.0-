using Pharmacy_Warehouse;
using System.Collections.Generic;

namespace Pharmacy_Warehouse_2._0_.Model.Delivery
{
    public interface IDeliveryNoteRepository
    {
        IEnumerable<DeliveryNote> GetAllDeliveryNotes();
        DeliveryNote GetDeliveryNoteById(int id);
        void AddDeliveryNote(DeliveryNote deliveryNote);
        void UpdateDeliveryNote(int id, DeliveryNote updatedDeliveryNote);
        void DeleteDeliveryNote(int id);
        void SaveDelieveryNote(int id, DeliveryNote delieveryNote);
    }
}

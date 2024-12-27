using Pharmacy_Warehouse;
using Pharmacy_Warehouse_2._0_.Model.Delivery;
using Pharmacy_Warehouse_2._0_.View.DelieveryNotesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Warehouse_2._0_.Presenter
{
    public class DeliveryNotePresenter
    {
        private readonly IDeliveryNoteView _deliveryNoteView;
        private readonly IDeliveryNoteRepository _deliveryNoteRepository;

        public DeliveryNotePresenter(IDeliveryNoteView deliveryNoteView, IDeliveryNoteRepository deliveryNoteRepository)
        {
            _deliveryNoteRepository = deliveryNoteRepository;
            _deliveryNoteView = deliveryNoteView;
            _deliveryNoteView.Presenter = this;

            _deliveryNoteView.LoadMainForm += OnLoadMainForm;

            UpdateDeliveryListView();
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            _deliveryNoteView.Hide();
        }

        private void UpdateDeliveryListView()
        {
            var deliveryNotes = _deliveryNoteRepository.GetAllDeliveryNotes();
            var deliveryNoteIds = deliveryNotes.Select(note => note.Id).ToList();

            int selectedDeliveryNote = _deliveryNoteView.SelectedDeliveryNote >= 0
                ? _deliveryNoteView.SelectedDeliveryNote
                : 0;

            _deliveryNoteView.IDeliveryList = deliveryNoteIds;
            _deliveryNoteView.SelectedDeliveryNote = selectedDeliveryNote;

            if (deliveryNotes.Any() && selectedDeliveryNote >= 0)
            {
                UpdateDeliveryNoteView(selectedDeliveryNote);
            }
        }

        public void UpdateDeliveryNoteView(int id)
        {
            var deliveryNote = _deliveryNoteRepository.GetDeliveryNoteById(id);
            if (deliveryNote == null) return;

            _deliveryNoteView.id = deliveryNote.Id;
            _deliveryNoteView.Date = deliveryNote.Date;
            _deliveryNoteView.Supplier = deliveryNote.Supplier;
            _deliveryNoteView.DeliveryItem = deliveryNote.Item;
        }

        public void SaveDeliveryNote()
        {
            var updatedNote = new DeliveryNote(
                _deliveryNoteView.id,
                _deliveryNoteView.Date,
                _deliveryNoteView.Supplier,
                _deliveryNoteView.DeliveryItem
            );

            _deliveryNoteRepository.UpdateDeliveryNote(_deliveryNoteView.SelectedDeliveryNote, updatedNote);
            UpdateDeliveryListView();
        }

        public void AddDeliveryNote()
        {
            var newNote = new DeliveryNote(
                Guid.NewGuid().ToString(),
                DateTime.Now,
                new Supplier("Новый поставщик", "Адрес", "Телефон"),
                new DeliveryItem(
                    new Medicine("Новое лекарство", "Категория", DateTime.Now, DateTime.Now.AddYears(2), "РегНомер", null, null),
                    0,
                    0
                )
            );

            _deliveryNoteRepository.AddDeliveryNote(newNote);
            UpdateDeliveryListView();
        }

        public void DeleteDeliveryNote()
        {
            if (_deliveryNoteView.SelectedDeliveryNote < 0) return;

            
            _deliveryNoteRepository.DeleteDeliveryNote(_deliveryNoteView.SelectedDeliveryNote);

            UpdateDeliveryListView();
        }
    }


}

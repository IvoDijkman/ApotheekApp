using ApotheekApp.Data;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Xunit;

namespace ApotheekApp.Tests
{
    [Collection("Database Tests")]
    public class PrescriptionServiceTests : UnitTestBase<IPrescriptionService>
    {
        private Prescription _prescription1;
        private Prescription _prescription2;
        private Prescription _prescription3;

        [Fact]
        public async Task Should_GetAll()
        {
            var allPrescriptions = _service.GetAll();
            int count = allPrescriptions.Result.Count();
            Assert.Equal(3, count);
        }

        [Fact]
        public async Task Should_GetAllOpenPrescriptions()
        {
            var openPrescriptions = _service.GetAllOpenPrescriptions();
            int count = openPrescriptions.Result.Count();
            Assert.Equal(2, count);
        }

        [Fact]
        public async Task Should_GetByIdAsync()
        {
            Prescription test = await _service.GetByIdAsync(1);
            Assert.Equal(test.Id, 1);
            Assert.Equal(test.Name, "TestPrescription1");
        }

        [Fact]
        public async Task Should_ToggleIsCollectedAsync()
        {
            bool IsCollected = false;
            Assert.False(IsCollected);
            IsCollected = await _service.ToggleIsCollectedAsync(1);
            Assert.True(IsCollected);
        }

        protected override Task SetupDatabase(DataContext context)
        {
            _prescription1 = new Prescription
            {
                Name = "TestPrescription1",
                IsCollected = false,
                Description = "TestPrescription1 Descr",
                ClientId = 1,
            };
            _prescription2 = new Prescription
            {
                Name = "TestPrescription2",
                IsCollected = false,
                Description = "TestPrescription2 Descr",
                ClientId = 2,
            };
            _prescription3 = new Prescription
            {
                Name = "TestPrescription3",
                IsCollected = true,
                Description = "TestPrescription3 Desc",
                ClientId = 1,
            };

            context.Add(_prescription1);
            context.Add(_prescription2);
            context.Add(_prescription3);

            return Task.CompletedTask;
        }
    }
}
using Digipets.API.Controllers;
using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Domain.Entities;
using Digipets.Test.FakeEntity;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NSubstitute.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Test.Controllers
{
    public class TutoresControllerTest
    {
        private readonly ITutorService _tutorService;
        private readonly IAnimalService _animalService;
        private readonly TutorController _tutorController;
        private readonly List<TutorDTO> _tutoresDTO;
        private readonly List<TutorDTO> _tutorDTO;
        private readonly List<AnimalDTO> _animaisDTO;
        private readonly AnimalDTO _animalDTO;
        public TutoresControllerTest()
        {
            _tutorService = Substitute.For<ITutorService>();
            _animalService = Substitute.For<IAnimalService>();
            _tutorController = new TutorController(_tutorService, _animalService);
            _tutoresDTO = new TutorDTOFaker().Generate(10);
            _tutorDTO = new TutorDTOFaker().Generate(1);
            _animaisDTO = new AnimalDTOFaker().Generate(3);
            _animalDTO = new AnimalDTOFaker().Generate();
        }

        [Fact]
        public async Task GetAll()
        {
            _tutorService.GetTutores().Returns(_tutoresDTO);

            var response = await _tutorController.GetAll();
            var result = response.Result as OkObjectResult;

            result.StatusCode.Should().Be(StatusCodes.Status200OK);
            result.Value.Should().BeEquivalentTo(_tutoresDTO);
        }

        [Fact]
        public async Task GetNotFound()
        {
            _tutorService.GetTutores().Returns(new List<TutorDTO>());

            var response = await _tutorController.GetAll();
            var result = response.Result as NotFoundResult;

            await _tutorService.Received().GetTutores();
            result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
        }

        [Fact]
        public async Task GetById()
        {
            var tutor = _tutorDTO.FirstOrDefault();
            _tutorService.GetById(tutor.Id).Returns(tutor);
            

            var response = await _tutorController.GetById(tutor.Id);
            var result = response.Result as OkObjectResult;

            result.StatusCode.Should().Be(StatusCodes.Status200OK);
            result.Value.Should().BeEquivalentTo(tutor);
        }

        [Fact]
        public async Task GetAnimaisByTutorId()
        {
            var animais = _animaisDTO;
            var tutor = _tutoresDTO.FirstOrDefault();
            _animalService.GetAnimaisByTutorId(tutor.Id).Returns(animais);

            var response = await _tutorController.GetAnimaisByTutorId(tutor.Id);
            var result = response.Result as OkObjectResult;

            result.StatusCode.Should().Be(StatusCodes.Status200OK);
            result.Value.Should().BeEquivalentTo(animais);
        }

        [Fact]
        public async Task PostNewAnimal()
        {
            var animal = _animalDTO;
            var tutor = _tutorDTO.FirstOrDefault();
            _animalService.Create(animal).Returns(animal); 

            var response = await _tutorController.PostNewAnimal(tutor.Id, animal);
            var result = response.Result as CreatedAtRouteResult;

            result.StatusCode.Should().Be(StatusCodes.Status201Created);
            result.Value.Should().BeEquivalentTo(_animalDTO);
        }
    }
}

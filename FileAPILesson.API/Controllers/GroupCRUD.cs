using FileAPILesson.Application.Services.GroupServices;
using FileAPILesson.Domain.Entities.DTOs;
using FileAPILesson.Domain.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileAPILesson.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupCRUD : ControllerBase
    {
        private readonly IGroupService _group;
        public GroupCRUD(IGroupService group)
        {
            _group = group;
        }

        [HttpGet]
        public async Task<IEnumerable<Group>> GetAllGroup()
        {
            return await _group.GetAllGroups();
        }
        [HttpGet]
        public async Task<Group> GetGroupById(int id)
        {
            return await _group.GetGroup(id);
        }
        [HttpPost]
        public async Task<string> CreateGruop([FromForm] GroupDTO gr)
        {
            return await _group.CreateGroup(gr);
        }
        [HttpPut]
        public async Task<string> UpdateGroup(int id, [FromForm] GroupDTO gr)
        {
            return await _group.UpdateGroup(id, gr);
        }
        [HttpDelete]
        public async Task<string> Deletegroup(int id)
        {
            return await _group.DeleteGroup(id);
        }
    }
}

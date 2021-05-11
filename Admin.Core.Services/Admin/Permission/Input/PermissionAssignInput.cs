using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Admin.Core.Service.Admin.Permission.Input
{
    public class PermissionAssignInput
    {
        [Required(ErrorMessage = "��ɫ����Ϊ�գ�")]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Ȩ�޲���Ϊ�գ�")]
        public List<int> PermissionIds { get; set; }
    }
}

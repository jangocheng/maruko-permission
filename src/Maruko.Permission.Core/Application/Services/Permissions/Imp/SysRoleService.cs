//===================================================================================
//此代码由代码生成器自动生成      
//对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
//===================================================================================
//作者:simple              
//创建时间：05-23-2019  
//版本1.0
//===================================================================================

using Maruko.ObjectMapping;
using Maruko.Permission.Core.Application.Services.Permissions.DTO.SysRole;
using Maruko.Permission.Core.Domain.Permissions;
using Maruko.Permission.Core.Domain.Permissions.IRepos;

namespace Maruko.Permission.Core.Application.Services.Permissions.Imp
{
    public class SysRoleService : CrudAppServiceCore<MkoRole, SysRoleDto, SearchSysRoleDto>, ISysRoleService
    {
        public SysRoleService(IObjectMapper objectMapper, ISysRoleRepos repository) : base(objectMapper, repository)
        {
        }
    }
}
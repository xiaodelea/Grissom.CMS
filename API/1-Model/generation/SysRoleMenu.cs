/*============================
 * 该文件由模板生成，请不要修改
 =============================*/
using System;
namespace Model
{
    /// <summary>
    /// 角色菜单 
    /// </summary>    
    public partial class SysRoleMenu
    {
        /// <summary>
        /// 角色id
        /// </summary>

		[PK]
		public long RoleId { get; set; }
    
        /// <summary>
        /// 菜单编码
        /// </summary>
        public string MenuCode { get; set; }
    }
}

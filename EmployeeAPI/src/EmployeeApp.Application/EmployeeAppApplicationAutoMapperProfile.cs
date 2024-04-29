using AutoMapper;

namespace EmployeeApp;

public class EmployeeAppApplicationAutoMapperProfile : Profile
{
    public EmployeeAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Employee, EmployeeDto>();
        CreateMap<CreateUpdateEmployeeDto, Employee>();
    }
}

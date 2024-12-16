using AutoMapper;
using eAccountingServer.Domain.Entities;
using eAccountingServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Companies.CreateCompany;

internal sealed class CreateCompanyCommandHandler(
    ICompanyRepository companyRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateCompanyCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        bool isTaxNumberExists = await companyRepository.AnyAsync(p => p.TaxNumber == request.TaxNumber, cancellationToken);

        if (isTaxNumberExists)
        {
            return Result<string>.Failure("Bu vergi numarası daha önce kaydedilmiş!");
        }

        Company company = mapper.Map<Company>(request);

        await companyRepository.AddAsync(company, cancellationToken);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Şirket başarıyla oluşturuldu.";
    }
}

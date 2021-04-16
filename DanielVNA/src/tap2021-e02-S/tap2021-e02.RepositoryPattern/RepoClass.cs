using System;
using System.Collections.Generic;
using System.Text;
using tap2021_e02.Data;

namespace tap2021_e02.RepositoryPattern
{
    public RegisterSampleTransaction(
        ISampleRepository<Sample> sampleRepository,
        IUnitOfWork unitOfWork)
    {

    }

    public void Execute(Sample sample)
    {
        ISampleRepository.InsertSample(sample);
        IUnitOfWork.Commit();
    }

    
}

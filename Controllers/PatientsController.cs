using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    private readonly ILogger<PatientsController> _logger;
    public PatientsController(ILogger<PatientsController> logger) => _logger = logger;

    [HttpPost]
    public IActionResult Post(PatientDto dto)
    {
        var phi = PhiScanner.GetPhiFields(dto).ToList();
        // Log PHI metadata (DO NOT return raw PHI back to caller)
        _logger.LogInformation("PHI properties detected: {PropsCount}. Names: {Props}", phi.Count, phi.Select(p => p.PropertyName).ToArray());

        // TODO: Persist audit event to audit table (later lab)
        return Ok(new { message = "received", phiCount = phi.Count });
    }
}

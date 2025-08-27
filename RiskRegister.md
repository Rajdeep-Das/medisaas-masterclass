# Risk Register — Day 1

## Risk 001 — Unauthorized PHI Access
- Description: Unauthorized user reads patient records
- Impact: High
- Likelihood: Medium
- Controls: RBAC, audit logging, encryption in transit
- Owner: Dev Lead
- Mitigation Plan: Implement RBAC, deploy audit middleware, review monthly

## Risk 002 — Credential leakage (dev secrets)
- Description: Secrets committed to repo or leaked
- Impact: High
- Likelihood: Medium
- Controls: gitignore, secret scanning, use Key Vault for later
- Owner: DevOps
- Mitigation Plan: Add pre-commit hooks, rotate secrets

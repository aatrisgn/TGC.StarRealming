output "b2c_tenant_id" {
  description = "The tenant ID of the Azure AD B2C directory."
  value       = azurerm_aadb2c_directory.this.tenant_id
}

output "b2c_domain_name" {
  description = "The domain name of the Azure AD B2C directory."
  value       = azurerm_aadb2c_directory.this.domain_name
}
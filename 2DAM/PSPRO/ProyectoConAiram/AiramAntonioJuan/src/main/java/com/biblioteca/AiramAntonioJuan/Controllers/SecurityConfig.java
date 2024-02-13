/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.biblioteca.AiramAntonioJuan.Controllers;

/**
 *
 * @author anton
 */
import org.springframework.context.annotation.Configuration;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;

@Configuration
@EnableWebSecurity
public class SecurityConfig extends WebSecurityConfigurerAdapter {

    protected void configure(HttpSecurity http) throws Exception {
        http
            .authorizeRequests()
                .antMatchers("/api/autores/**").authenticated()
                .antMatchers("/api/categorias/**").authenticated()
                .antMatchers("/api/libros/**").authenticated()
                .and()
            .formLogin()
                .loginPage("/login")
                .successHandler((request, response, authentication) -> {
                    response.sendRedirect("http://localhost:4200"); // Redirige al frontend de Angular después del inicio de sesión exitoso
                })
                .permitAll()
                .and()
            .logout()
                .permitAll();
    }
}
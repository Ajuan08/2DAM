package DAO;

import java.sql.ResultSet;
import org.junit.Test;
import static org.junit.Assert.*;

public class DAOAlumnosTest {
   
    @Test
    public void testGetNotasAlumnosById() {
        int idAlumno = 1; 
        DAOAlumnos daoAlumnos = new DAOAlumnos();
        ResultSet result = daoAlumnos.getNotasAlumnosById(idAlumno);
        assertNotNull(result);
        
    }
}

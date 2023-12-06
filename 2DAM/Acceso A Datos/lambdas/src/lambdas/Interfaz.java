package lambdas;

@FunctionalInterface
public interface Interfaz<T> {
	T calcular(int... numbers);
}

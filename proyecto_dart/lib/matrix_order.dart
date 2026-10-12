class MatrixOrder {
  static void bubbleSortOrderMatrix(
    List<List<double>> m,
    List<int> intercambios,
  ) {
    for (int i = 0; i < m.length; i++) {
      int contador = 0;

      for (int j = 0; j < m[i].length - 1; j++) {
        for (int k = 0; k < m[i].length - 1 - j; k++) {
          if (m[i][k] > m[i][k + 1]) {
            double aux = m[i][k];
            m[i][k] = m[i][k + 1];
            m[i][k + 1] = aux;
            contador++;
          }
        }
      }
      intercambios[i] = contador;
    }
  }
}

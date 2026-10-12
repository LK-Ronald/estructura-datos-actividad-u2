import 'package:cli/matrix_order.dart';

void main() {
  final notas = [
    [2.4, 4.3, 3.2],
    [5.0, 1.5, 2.2],
    [4.4, 3.3, 3.9],
    [4.4, 4.3, 2.8],
    [3.1, 3.0, 4.2],
  ];

  final count = List<int>.filled(notas.length, 0);

  print('-------- Sin ordenar ---------');
  mostrarMatrix(notas);

  print('-------- Ordenado ---------');
  MatrixOrder.bubbleSortOrderMatrix(notas, count);
  mostrarMatrix(notas);

  mostrarContabilizacion(count);
}

void mostrarMatrix(List<List<double>> m) {
  for (int x = 0; x < m.length; x++) {
    print('Estudiante $x:');
    for (int y = 0; y < m[x].length; y++) {
      print(' | ${m[x][y]} |');
    }
  }
}

void mostrarContabilizacion(List<int> count) {
  print('----- Contabilizador de cambios --------');
  for (int i = 0; i < count.length; i++) {
    print('Estudiante $i : ${count[i]}');
  }
}

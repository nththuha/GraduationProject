package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.BoPhanEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class BoPhanDTO {
    private String maBP;

    private String tenBP;

    public BoPhanDTO(BoPhanEntity boPhanEntity) {
        this.maBP = boPhanEntity.getMaBP();
        this.tenBP = boPhanEntity.getTenBP().name();
    }
}
